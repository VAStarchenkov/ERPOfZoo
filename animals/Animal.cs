// Интерфейсы
public interface IAlive
{
    int Food { get; }
}

public interface IInventory
{
    int Number { get; }
}

// Базовые классы
public abstract class Animal : IAlive, IInventory
{
    public int Food { get; protected set; }
    public int Number { get; }
    public string Name { get; }

    protected Animal(string name, int food, int number)
    {
        Name = name;
        Food = food;
        Number = number;
    }
}