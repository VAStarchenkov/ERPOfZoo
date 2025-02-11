// Зоопарк
public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly List<IInventory> _inventory = new();
    private readonly VetClinic _vetClinic;

    public Zoo(VetClinic vetClinic)
    {
        _vetClinic = vetClinic;
    }

    public void AddAnimal(Animal animal)
    {
        if (_vetClinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            _inventory.Add(animal);
            Console.WriteLine($"{animal.Name} (#{animal.Number}) добавлен в зоопарк.");
        }
        else
        {
            Console.WriteLine($"{animal.Name} (#{animal.Number}) не принят в зоопарк из-за проблем со здоровьем.");
        }
    }

    public void AddThing(Thing thing)
    {
        _inventory.Add(thing);
        Console.WriteLine($"{thing.Name} (#{thing.Number}) добавлен в инвентарь.");
    }
    
    public void ReportFoodConsumption()
    {
        int totalFood = 0;
        foreach (var animal in _animals)
        {
            totalFood += animal.Food;
        }
        Console.WriteLine($"Общее потребление еды в день: {totalFood} кг");
    }

    public void ListInteractiveAnimals()
    {
        Console.WriteLine("Животные, доступные для контактного зоопарка:");
        foreach (var animal in _animals)
        {
            if (animal is Herbivore herbivore && herbivore.Kindness > 5)
            {
                Console.WriteLine($"{animal.Name} (#{animal.Number})");
            }
        }
    }
    
    public void ListInventory()
    {
        Console.WriteLine("Инвентарь зоопарка:");
        foreach (var item in _inventory)
        {
            Console.WriteLine($"{item.GetType().Name}: #{item.Number}");
        }
    }
}