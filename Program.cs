namespace InheritanceApp;

public interface IAnimal
{
    string Name { get; set; }
    string Species { get; }
    void DisplayInfo();
    void Sound();
}


public abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public abstract string Species { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void DisplayInfo();
    public abstract void Sound();
    public abstract void Eat(string meat);
}


public class Tiger : Animal
{
    public override string Species => "Tiger";
    public double length { get; set; }

    public Tiger(string name, double length) : base(name)
    {
        this.length = length;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Length: {length}");
    }

    public override void Sound()
    {
        Console.WriteLine("GR GR");
    }

    public override void Eat(string meat)
    {
        Console.WriteLine($"Tiger has eaten {meat}");
    }
}


public class Crocodile : Animal
{
    public override string Species => "Crocodile";
    public double Length { get; set; }

    public Crocodile(string name, double length) : base(name)
    {
        Length = length;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Length: {Length} meters");
    }

    public override void Sound()
    {
        Console.WriteLine("AMG AMG");
    }

    public override void Eat(string meat)
    {
        Console.WriteLine($"Crocodile has eaten {meat}");
    }
}


public class Kangaroo : Animal
{
    public override string Species => "Kangaroo";
    public double JumpHeight { get; set; }

    public Kangaroo(string name, double jumpHeight) : base(name)
    {
        JumpHeight = jumpHeight;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Jump Height: {JumpHeight} meters");
    }

    public override void Sound()
    {
        Console.WriteLine("OP OP");
    }

    public override void Eat(string meat)
    {
        Console.WriteLine($"Kangaroo has eaten {meat}");
    }
}


class Program
{
    static void Main()
    {
        Animal tiger = new Tiger("Tiger", 2);
        Animal crocodile = new Crocodile("Gena", 6.2);
        Animal kangaroo = new Kangaroo("Bob", 4.0);

        DisplayAnimalInfo(tiger);
        DisplayAnimalInfo(crocodile);
        DisplayAnimalInfo(kangaroo);
    }

    static void DisplayAnimalInfo(Animal animal)
    {
        animal.DisplayInfo();
        animal.Sound();
        Console.WriteLine();
    }
}


/*
Name: Tiger
Species: Tiger
Length: 2
GR GR

Name: Gena
Species: Crocodile
Length: 6,2 meters
AMG AMG

Name: Bob
Species: Kangaroo
Jump Height: 4 meters
OP OP


C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 18940) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:
*/
