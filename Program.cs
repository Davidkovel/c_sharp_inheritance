namespace InheritanceApp;
public interface IWorker
{
    void Print();
}


public abstract class Worker : IWorker
{
    public string Name { get; set; }
    public string Position { get; set; }

    Worker()
    {
        this.Name = "Null";
        this.Position = "Null";
    }
    public Worker(string name, string position) : this()
    {
        Name = name;
        Position = position;
    }

    public abstract void Print();
}


public class President : Worker
{
    public President(string name) : base(name, "President") { }

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}");
        Console.WriteLine("Presindent is working in Goverment");
    }
}

public class Security : Worker
{
    public Security(string name) : base(name, "Security") { }

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}");
        Console.WriteLine("Security check for security");
    }
}


public class Manager : Worker
{
    public Manager(string name) : base(name, "Manager") { }

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}");
        Console.WriteLine("Oversees the operations and performance of a specific department.");
    }
}

public class Engineer : Worker
{
    public Engineer(string name) : base(name, "Engineer") { }

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}");
        Console.WriteLine("Designs, develops, and maintains the company's products and systems.");
    }
}

class Program
{
    static void Main()
    {
        IWorker president = new President("Alice");
        IWorker security = new Security("Bob");
        IWorker manager = new Manager("Charlie");
        IWorker engineer = new Engineer("Diana");

        IWorker[] workers = { president, security, manager, engineer };

        foreach (var worker in workers)
        {
            worker.Print();
            Console.WriteLine();
        }
    }
}


/*
Name: Alice, Position: President
Presindent is working in Goverment

Name: Bob, Position: Security
Security check for security

Name: Charlie, Position: Manager
Oversees the operations and performance of a specific department.

Name: Diana, Position: Engineer
Designs, develops, and maintains the company's products and systems.


C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 20256) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 */