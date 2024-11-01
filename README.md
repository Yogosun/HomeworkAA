Это простое консольное приложение на C# для имитации процесса доставки еды из ресторанов. Программа позволяет добавлять блюда в корзину, создавать заказы и отслеживать их статус.

Функциональность включает:
    Просмотр меню: 
        Позволяет пользователям просмотреть доступные блюда, которые представлены разными категориями (пицца, бургер, суши и др.).
    
    Добавление блюд в корзину:
        Возможность выбрать блюдо из меню и добавить его в корзину.
    
    Удаление блюд из корзины:
        Пользователи могут удалить блюдо из корзины, указав его название.
    
    Просмотр стоимости корзины:
        Рассчитывается полная стоимость всех блюд, добавленных в корзину.
    
    Создание заказа:
        Создание заказа по текущей корзине, после чего корзина очищается.
    
    Проверка статуса заказа:
        Заказ проходит несколько статусов — «создан», «в обработке», «в доставке», «доставлен».
    
    Просмотр истории заказов:
        Отображение всех ранее созданных заказов с их текущим статусом.

Основные классы:
    MenuItem:
        Абстрактный базовый класс для всех блюд. Каждый конкретный тип блюда наследует от этого класса, задавая название и цену в конструкторе.
        Конкретные классы блюд: (Pizza, Burger, Sushi, Pasta, Salad).

    Menu:
        Класс, представляющий меню приложения. Содержит коллекцию доступных блюд и методы для получения блюд по ID.

    Basket:
        Корзина пользователя для добавления и удаления блюд, а также расчета общей стоимости.

    OrderService:
        Сервис для работы с заказами. Обрабатывает создание заказов, добавление блюд в корзину и проверку статуса заказов.

    OrderProcessingSimulator:
        Запускает обработку заказов, меняя их статус с заданной периодичностью.

    EventStore:
        Реализует паттерн Event Sourcing, храня события, такие как добавление блюда в корзину и изменение статуса заказа.

Использованные паттерны:
    CQRS:
        Команды и запросы разделены по отдельным методам.
    
    Event Sourcing:
        События записываются в EventStore, что позволяет хранить историю операций и отслеживать изменения.

Общая структура приложения:
    Data Layer:
        Для хранения всех событий, которые представляют изменения состояния корзины и заказов.
    
    Domain Layer:
        Логика корзины и заказа.

    Service Layer:
        Управляет командами и запросами.

    Application Layer:
        Консольный интерфейс для взаимодействия с пользователем.

