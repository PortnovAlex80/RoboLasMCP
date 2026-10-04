// Automation/LasAutomationException.cs
// Ошибки headless-автоматизации RoboLas (MCP/IPC-вызовы без диалогов).
using System;

namespace LAS_TERRAIN.Automation
{
    /// <summary>
    /// Ошибка автоматизации: нет активной трассы, нет LAS-источника,
    /// операция занята, параметры некорректны и т.п. Сообщение адресовано
    /// вызывающему агенту и должно подсказывать следующий шаг.
    /// </summary>
    public class LasAutomationException : Exception
    {
        public LasAutomationException(string message) : base(message) { }

        public LasAutomationException(string message, Exception inner)
            : base(message, inner) { }
    }

    /// <summary>
    /// Отмена пользователем (кнопка Отмена в прогресс-баре Robur). Не ошибка:
    /// публичные операции ловят её и возвращают результат с Cancelled=true.
    /// </summary>
    public class LasAutomationCancelledException : LasAutomationException
    {
        public LasAutomationCancelledException()
            : base("Операция отменена пользователем.") { }
    }
}
