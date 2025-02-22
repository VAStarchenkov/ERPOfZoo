# Московский зоопарк - консольное приложение для учета животных и инвентаря

## Описание

Данное консольное приложение разработано для учета животных Московского зоопарка, а также для инвентаризации предметов. Программа позволяет:

- Добавлять животных в зоопарк (с предварительной проверкой здоровья).
- Добавлять предметы в инвентарь.
- Выводить список животных, доступных для контактного зоопарка.
- Формировать отчет по потреблению пищи животными.
- Выводить полный список инвентаря.

## Принципы SOLID в коде

### **S - Single Responsibility Principle (Принцип единственной ответственности)**
- Классы `Animal`, `Herbivore`, `Predator` и их подклассы отвечают только за представление информации о животных.
- `Thing` и его подклассы (например, `Table`, `Computer`) отвечают только за инвентарь.
- `Zoo` управляет добавлением животных и вещей, а также отчетами.
- `VetClinic` занимается проверкой здоровья животных.

### **O - Open/Closed Principle (Принцип открытости/закрытости)**
- Новые виды животных и предметов можно легко добавить, унаследовав соответствующие классы (`Animal`, `Thing`), без изменения существующего кода.

### **L - Liskov Substitution Principle (Принцип подстановки Барбары Лисков)**
- Все подклассы `Animal` (такие как `Monkey`, `Tiger`) можно использовать вместо базового класса `Animal`, не нарушая работу программы.

### **I - Interface Segregation Principle (Принцип разделения интерфейсов)**
- Интерфейсы `IAlive` и `IInventory` обеспечивают разделение ответственности: животные реализуют `IAlive`, а инвентарные предметы — `IInventory`. Это позволяет не перегружать один интерфейс ненужными методами.

### **D - Dependency Inversion Principle (Принцип инверсии зависимостей)**
- В коде используется DI-контейнер (`Microsoft.Extensions.DependencyInjection`), что позволяет передавать зависимости (`VetClinic`, `Zoo`) через конструкторы, а не создавать их напрямую внутри классов.

## Инструкция по запуску

### **Требования**
- .NET 9 SDK

### **Шаги для запуска**
1. Клонировать репозиторий или скопировать код проекта.
2. Открыть терминал или командную строку в папке проекта.
3. Выполнить команду для сборки проекта:
   ```sh
   dotnet build
   ```
4. Запустить приложение:
   ```sh
   dotnet run
   ```

### **Как пользоваться**
После запуска в консоли появится меню с вариантами действий:
- `1` — Добавить животное (с выбором вида и номера).
- `2` — Добавить предмет в инвентарь (с выбором предмета и номера).
- `3` — Показать животных, подходящих для контактного зоопарка.
- `4` — Вывести отчет по потреблению пищи животными.
- `5` — Вывести полный список инвентаря.
- `Esc` — Выход из программы.

## Развитие проекта
В будущем планируется:
- Добавление новых категорий животных и предметов.
- Улучшение логики проверки здоровья животных.
- Ведение истории событий в зоопарке (поступление новых животных, списание предметов).

