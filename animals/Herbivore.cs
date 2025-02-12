// Класс тровоядные животные
public abstract class Herbivore : Animal
{
    public int Kindness { get; }
    
    protected Herbivore(string name, int food, int number, int kindness) 
        : base(name, food, number)
    {
        Kindness = kindness;
    }
}