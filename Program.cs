namespace InheritanceApp;

public abstract class Device
{
    public string Name { get; set; }
    public string Characteristics { get; set; }

    public Device(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public abstract void Sound();
    public void Show()
    {
        Console.WriteLine($"Device Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }
}

public class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Kettle sound: Whistleeeeeeeee");
    }
}


public class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Microwave sound: Beep Beep");
    }
}


public class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Car sound: Vroooooo");
    }
}


public class Steamboat : Device
{
    public Steamboat(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Steamboat sound: Hornnnn");
    }
}




class Program
{
    static void Main()
    {
        Device kettle = new Kettle("Kettle", "Boils water");
        Device microwave = new Microwave("Microwave", "Heats food");
        Device car = new Car("BMW", "Comfortable for racing car");
        Device steamboat = new Steamboat("Boat", "Used to transport people in cruise");

        Device[] devices = { kettle, microwave, car, steamboat };

        foreach (var device in devices)
        {
            device.Show();
            device.Desc();
            device.Sound();
            Console.WriteLine();
        }
    }
}



/*
Device Name: Kettle
Description: Boils water
Kettle sound: Whistleeeeeeeee

Device Name: Microwave
Description: Heats food
Microwave sound: Beep Beep

Device Name: BMW
Description: Comfortable for racing car
Car sound: Vroooooo

Device Name: Boat
Description: Used to transport people in cruise
Steamboat sound: Hornnnn


C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 11416) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:
*/
