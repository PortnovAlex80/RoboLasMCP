# Инструкция по сборке .NET Framework 3.5 проекта

## Быстрая сборка (рекомендуется)

### PowerShell

```powershell
# Сборка в D:\LAS_TERRAIN_BUILD
.\build\build_local.ps1

# Или с указанием версии
.\build\build_local.ps1 -Version 1.0.1
```

### Git Bash

```bash
# Сборка в D:\LAS_TERRAIN_BUILD
./build/build_local.sh

# С указанием версии
./build/build_local.sh 1.0.1
```

## Результат сборки

После сборки в `D:\LAS_TERRAIN_BUILD`:

```
D:\LAS_TERRAIN_BUILD\
├── LAS_TERRAIN.dll          # Основная библиотека
├── LAS_TERRAIN.pdb          # Отладочные символы
├── LAS_TERRAIN.plugin       # Описание плагина
├── Icons\                   # Иконки (с сохранением структуры папок)
│   ├── ic_panel\
│   ├── robolas_icons_pack\
│   └── ...
└── LAS_TERRAIN-1.0.0.tpm    # Готовый пакет для установки
```

## Создание пакета

```powershell
# Создать пакет из существующей сборки
.\build\package.ps1

# С указанием версии
.\build\package.ps1 -Version 2.0.0

# Из другой папки
.\build\package.ps1 -BuildPath D:\MyBuild -Version 1.5.0
```

## Ручная сборка

### PowerShell

```powershell
# Сборка в D:\LAS_TERRAIN_BUILD
msbuild LAS_TERRAIN.csproj /p:Configuration=Release /p:OutputPath="D:\LAS_TERRAIN_BUILD" /v:minimal

# Копирование plugin и иконок
Copy-Item LAS_TERRAIN.plugin D:\LAS_TERRAIN_BUILD\
Copy-Item RobolasIcons D:\LAS_TERRAIN_BUILD\Icons -Recurse

# Создание пакета
.\build\package.ps1
```

### Git Bash

```bash
"/c/Program Files/Microsoft Visual Studio/2022/Community/MSBuild/Current/Bin/MSBuild.exe" LAS_TERRAIN.csproj //p:Configuration=Release //p:OutputPath="D:\LAS_TERRAIN_BUILD" //v:minimal
```

## Параметры MSBuild

| Параметр | Описание | Пример |
|----------|----------|--------|
| `/p:Configuration` | Конфигурация сборки | `Release` или `Debug` |
| `/p:OutputPath` | Папка вывода | `D:\LAS_TERRAIN_BUILD` |
| `/p:TopomaticPath` | Путь к Topomatic | `"C:\Program Files\Topomatic Robur Rail 16.0"` |
| `/v:minimal` | Минимальный вывод | |
| `/v:normal` | Обычный вывод | |
| `/v:detailed` | Подробный вывод | |
| `/t:Rebuild` | Полная пересборка | |
| `/t:Clean` | Очистка | |

## Сборка с установкой в Topomatic

Для установки напрямую в папку Topomatic требуются права администратора:

```powershell
# Запустите PowerShell от имени администратора
$env:PATH = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin;$env:PATH"
msbuild LAS_TERRAIN.csproj /p:Configuration=Release "/p:TopomaticPath=C:\Program Files\Topomatic Robur Rail 16.0"
```

## Быстрые скрипты проекта

```powershell
# Сборка + упаковка в .tpm
.\build\package.ps1 -Version 1.0.1 -Build

# Только упаковка (без пересборки)
.\build\package.ps1 -Version 1.0.1

# Сборка без упаковки
.\build\build.ps1
```

## Типичные проблемы

### 1. MSBuild не найден
```
Ошибка: "msbuild" не является внутренней или внешней командой
```
**Решение:** Добавьте путь к MSBuild в PATH или используйте полный путь.

### 2. Нет прав на запись в Program Files
```
Ошибка: Отказано в доступе
```
**Решение:** Используйте параметр `/p:OutputPath` для вывода во временную папку или запустите от имени администратора.

### 3. Не найден .NET Framework 3.5
```
Ошибка: The target framework version 'v3.5' cannot be targeted
```
**Решение:** Включите .NET Framework 3.5 через "Включение или отключение компонентов Windows":
```
Панель управления → Программы → Включение или отключение компонентов Windows → .NET Framework 3.5
```

### 4. Файл занят другим процессом
```
Ошибка: не удалось скопировать файл
```
**Решение:** Закройте Topomatic или другие процессы, использующие DLL.

## Структура пакета

Пакет `.tpm` содержит плоскую структуру иконок:

```
LAS_TERRAIN-1.0.0.tpm
├── package.json
├── bin/
│   ├── LAS_TERRAIN.dll
│   └── LAS_TERRAIN.pdb
├── icons/                    # ВСЕ иконки плоско здесь!
│   ├── ic_lidar_surface_clip_robolas_16dp_1x.png
│   ├── robolas_panel_16dp_1x.png
│   └── ... (все 73 иконки)
└── plugins/
    └── LAS_TERRAIN.plugin
```

**ВАЖНО:** Иконки копируются из `RobolasIcons/` плоско в `icons/`, 
без сохранения вложенности папок (`ic_panel/`, `*_pack/` и т.д.).

