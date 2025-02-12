// Конкретные классы животных
public class Monkey : Herbivore
{
    public Monkey(int number) : base("Monkey", 3, number, 6) {}
}

public class Rabbit : Herbivore
{
    public Rabbit(int number) : base("Rabbit", 2, number, 7) {}
}

public class Tiger : Predator
{
    public Tiger(int number) : base("Tiger", 10, number) {}
}

public class Wolf : Predator
{
    public Wolf(int number) : base("Wolf", 7, number) {}
}