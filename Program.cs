using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

// Программа
class Program
{
    static void Main()
    {
        Console.WriteLine("Добро подаловать в систему по учету данных зоопарка!");

        var serviceProvider = new ServiceCollection()
            .AddSingleton<VetClinic>()
            .AddSingleton<Zoo>()
            .BuildServiceProvider();
        
        var zoo = serviceProvider.GetRequiredService<Zoo>();
        
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1 - Добавить животное");
            Console.WriteLine("2 - Добавить вещь в инвентарь");
            Console.WriteLine("3 - Вывести список животных для контактного зоопарка");
            Console.WriteLine("4 - Вывести отчет по животным");
            Console.WriteLine("5 - Вывести полный инвентарь");
            Console.WriteLine("Нажмите Esc для выхода\n");
            
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape) break;
            
            switch (key.KeyChar)
            {
                case '1':
                    Console.WriteLine("Выберите животное (Monkey, Rabbit, Tiger, Wolf):");
                    string? animalType = Console.ReadLine();
                    Console.Write("Введите номер животного: ");
                    if (int.TryParse(Console.ReadLine(), out int animalNumber))
                    {
                        Animal? animal = animalType switch
                        {
                            "Monkey" => new Monkey(animalNumber),
                            "Rabbit" => new Rabbit(animalNumber),
                            "Tiger" => new Tiger(animalNumber),
                            "Wolf" => new Wolf(animalNumber),
                            _ => null
                        };
                        if (animal != null) zoo.AddAnimal(animal);
                        else Console.WriteLine("Некорректный вид животного.");
                    }
                    else Console.WriteLine("Некорректный номер животного.");
                    break;
                case '2':
                    Console.WriteLine("Выберите предмет (Table, Computer):");
                    string? thingType = Console.ReadLine();
                    Console.Write("Введите номер предмета: ");
                    if (int.TryParse(Console.ReadLine(), out int thingNumber))
                    {
                        Thing? thing = thingType switch
                        {
                            "Table" => new Table(thingNumber),
                            "Computer" => new Computer(thingNumber),
                            _ => null
                        };
                        if (thing != null) zoo.AddThing(thing);
                        else Console.WriteLine("Некорректный вид предмета.");
                    }
                    else Console.WriteLine("Некорректный номер.");
                    break;
                case '3':
                    zoo.ListInteractiveAnimals();
                    break;
                case '4':
                    zoo.ReportFoodConsumption();
                    break;
                case '5':
                    zoo.ListInventory();
                    break;
                default:
                    Console.WriteLine("Некорректная команда, попробуйте снова.");
                    break;
            }
        }
        Console.WriteLine("Спасибо, что воспользовались нашей системой, до новых встреч!");
    }
}
