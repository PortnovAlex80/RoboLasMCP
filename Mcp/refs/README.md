# refs/ — сборочная ссылка на Topomatic.ToolBridge

`Topomatic.ToolBridge.dll` здесь — **оригинальная DLL из официального пакета
robur-mcp 0.1** (`robur_mcp-0_1.tpm`, https://topomatic.ru/plugins-robur/free-plugins-robur/),
используется только как compile-time ссылка проекта `LasTerrain.Mcp.csproj`.

Identity: `Topomatic.ToolBridge, Version=0.1.0.0, Culture=neutral, PublicKeyToken=0af0f61cef2ab3a8`
(`Private=False` — в выходной каталог и дистрибутив RoboLas не попадает).

В рантайме используется DLL из установки robur-mcp у пользователя; благодаря
совпадению имени/версии/токена привязка идёт к ней. Источник robur-mcp — MIT:
https://github.com/topomatic-code/robur-mcp

Обновление ссылки при выходе новой версии robur-mcp: скачать новый .tpm,
распаковать (это zip) и заменить `refs/Topomatic.ToolBridge.dll` здесь.
