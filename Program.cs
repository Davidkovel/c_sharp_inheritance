namespace InheritanceApp;


public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

public class Builder : Human
{
    public string ConstructionSite { get; set; }

    public Builder(string name, int age, string constructionSite)
        : base(name, age)
    {
        ConstructionSite = constructionSite;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is building at {ConstructionSite}.");
    }
}

public class Sailor : Human
{
    public string ShipName { get; set; }

    public Sailor(string name, int age, string shipName)
        : base(name, age)
    {
        ShipName = shipName;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is sailing on {ShipName}.");
    }
}

public class Pilot : Human
{
    public string AircraftModel { get; set; }

    public Pilot(string name, int age, string aircraftModel)
        : base(name, age)
    {
        AircraftModel = aircraftModel;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is flying {AircraftModel}.");
    }
}



class Program
{
    static void Main()
    {
        Human human_pilot = new Pilot(name: "Bob", age: 25, aircraftModel: "Boing");
        human_pilot.Work();
    }
}

/*
Bob is flying Boing.

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 12856) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 
*/