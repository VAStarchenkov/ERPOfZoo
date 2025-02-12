// Создание абстрактного класса - вещи
public abstract class Thing : IInventory
{
    public int Number { get; }
    public string Name { get; }
    
    protected Thing(string name, int number)
    {
        Name = name;
        Number = number;
    }
}