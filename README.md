# Finist-TestTask
Тестовое задание для компании Finist

# Приложение имеет 2 базы данных (postgresql)
## Одна для Identity, другая для самой логики.
#Быстрые настройки докера -

>docker run --name Finist-Identity -p 5434:5432 -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=Qwerty123@! -e POSTGRES_HOST_AUTH_METHOD=trust -v pg_data:/var/lib/postgresql/data -d postgres
>docker run --name Finist-Clients -p 5433:5432 -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=Qwerty123@! -e POSTGRES_HOST_AUTH_METHOD=trust -v pg_data:/var/lib/postgresql/data -d postgres

##Настройки всех БД храняться в соответсвующих проектах appsettings.Development.json

#Адрес gRPC для шлюза указан в самом методе контроллера

#Все данные уже заложены в миграцию, так же она должна автоматически примениться!
##Сделано несколько аккаунтов
###Данные для входа
>Логин : +79980007633 Пароль : string
>Логин : +79992223344 Пароль : password

#React интегрирован в приложение Finist.TestTask.WebApp запуск посредством SPA-proxy


В реакте все адреса эндпоинтов вынесены в src/constants/endpoints.js

Описание задания : 
#Задание
Необходимо реализовать личный кабинет клиента банка.
#Веб клиент
Реализовать нужно на React.
При открытии страницы форма входа клиента в личный кабинет, если клиент найден и аутентифицирован, отображаются его ФИО и список его счетов. 
Веб клиент получает данные из Веб шлюза по REST Api
#Веб шлюз
Приложение на ASP.NET Core. 
Является только шлюзом, не реализует никакой логики и хранение данных. 
При получении запросов, Веб шлюз обращается за данными к Службе бизнес логики по Grpc.
Предоставляет  REST Api для внешних запросов (в т.ч. из  Веб клиента)
#Служба бизнес логики
Приложение на ASP.NET Core. 
Служба Grpc.
Взаимодействует с ДБ через Entity Framework Core.
