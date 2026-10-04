# Card 10 — Транзакции и undo: BeginUpdate / EndUpdate / UpdateLoop

> Тема: как правильно оборачивать пакетные правки в транзакции.
> **Вердикт: ✅ VERIFIED** — опирается на `MASTER_REPORT.md` §3 (Transactions/Undo).

---

## Контракт (verified)

| Сигнатура | Файл:строка |
|---|---|
| `public abstract class UndoObject` (base) | `Topomatic.FoundationClasses.cs` |
| `public virtual bool BeginUpdate()` — открывает пустую parented `Transaction`, без snapshot | `Topomatic.FoundationClasses.cs:25854-25866` |
| `public virtual void EndUpdate()` — undo bookkeeping + событие, **НЕ** триангулирует | `Topomatic.FoundationClasses.cs:9272-9309` |
| Только **внешний** `EndUpdate` коммитит в undo-стек | `Topomatic.FoundationClasses.cs:25622` |
| `public static class UpdateLoop` — `BeginUpdateLoop()` extension (2 перегрузки) → `IDisposable` | `Topomatic.FoundationClasses.cs:25878`, `:25909`, `:25916` |
| `UpdateLoop.BeginTransaction()` = alias для BeginUpdate/EndUpdate | `Topomatic.FoundationClasses.cs:25923-25935` |
| `TransactableUpdateLoop.CreateProjectLoop()` — project-level loop (для регистрации моделей) | в теле |

### Undo-модель
- Undo = **Command pattern**, не memento. `ICommand.Undo()` возвращает обратную операцию (`FoundationClasses.cs:9321-9324`). `Transaction.Undo()` реверс-обходит детей.
- Non-undoable команда **отравляет** всю историю: чистит redo, может чистить undo (`FoundationClasses.cs:25650-25658`).
- Лимит истории undo по умолчанию — **64 транзакции**.
- **НЕ потокобезопасно** — голый `int++`/`int--` на счётчике (`FoundationClasses.cs:25864`). Все правки — на UI-потоке.

---

## ✅ Канонический паттерн: `try/finally` с BeginUpdate/EndUpdate

```csharp
alg.Plan.BeginUpdate();
try {
    // ... пакет правок ...
}
finally { alg.Plan.EndUpdate(); }
```

> ⚠️ **Всегда** в `finally`. Если исключение прервёт — без `finally` останется открытая транзакция, и следующий `EndUpdate` закроет её как «внешнюю», запомнив неконсистентное состояние.

## ✅ Сахар: `using` + `BeginUpdateLoop`

```csharp
using (alg.Plan.BeginUpdateLoop()) {
    // ... пакет правок ...
}   // Dispose вызывает EndUpdate
```

Перегрузки:
- `BeginUpdateLoop(this IUpdatable)` — `FoundationClasses.cs:25909`
- `BeginUpdateLoop(this INamedTransactable, string name)` — `:25916`

## ✅ Project-loop для регистрации модели

```csharp
using var loop = TransactableUpdateLoop.CreateProjectLoop();
try {
    // ... PluginCoreOps.CreateModel, populate ...
}
catch { loop.Commit = false; throw; }
finally { loop.Commit = true; }
```

GOLD: `Topomatic.Glg.Controller.cs:60084` (см. card 01).

---

## ❌ Подводные камни

| Проблема | Следствие |
|---|---|
| Забыть `finally` | зависшая транзакция при исключении |
| Правки на рабочем потоке | гонки (счётчик не thread-safe) — маршализовать на UI |
| Non-undoable команда в середине истории | отравляет undo/redo |
| Думать, что `EndUpdate` перестроит TIN | НЕ перестроит (см. card 08) |
| `Transaction.CanUndo` для 3M точек | итерирует все N — доминирующий риск по времени |
| Per-point `PointEditor.Add` для bulk-загрузки | per-point BeginUpdate/EndUpdate + ~40B cmd → ~144MB undo overhead для 3M точек (используйте raw `Points.Add`, см. card 08) |

---

## 🔗 Связанные
- `docs/topomatic-sweep/reports/MASTER_REPORT.md` §3 (Transactions/Undo)
- [01 — Создание Alignment](01-alignment-creation.md)
- [02 — План (PlanLine)](02-planline-geometry.md)
- [08 — Surface/TIN](08-surface-tin-internals.md)
