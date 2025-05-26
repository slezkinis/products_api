# API продуктов на .NET


## Установка
1. Установите [.NET 8](https://learn.microsoft.com/ru-ru/dotnet/core/install/)
2. Установите `dotnet-ef`
``` sh
dotnet tool install --global dotnet-ef --version "8.*"
```
3. Перейдите в каталог `src/`
4. Проведите миграции БД командой:
``` sh
dotnet ef database update 
```

## Запуск

Запустите DEV-сервер:
``` sh
dotnet watch run
```

## PS
Не совсем разобрался, как здесь работают зависимости и как их установить одной командой (как в питоне pip3 install -r requirements.txt). А так вроде всё реализовал :)