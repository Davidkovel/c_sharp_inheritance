namespace InheritanceApp;
public abstract class MusicalInstrument
{
    public string Name { get; set; }
    public string Characteristics { get; set; }

    MusicalInstrument() { }

    public MusicalInstrument(string name, string characteristics) : this()
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Default instrument sound");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Instrument Name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public virtual void History()
    {
        Console.WriteLine("Default instrument history");
    }
}


public class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Violin sound: Screech");
    }

    public override void History()
    {
        Console.WriteLine("The violin, sometimes known as a fiddle, is a wooden string instrument in the violin family.");
    }
}


public class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Trombone sound: Blare");
    }

    public override void History()
    {
        Console.WriteLine("The trombone is a brass instrument in the brass family.");
    }
}



public class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele sound: Strum");
    }

    public override void History()
    {
        Console.WriteLine("The ukulele is a member of the lute family of instruments.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Cello sound: Deep and rich");
    }

    public override void History()
    {
        Console.WriteLine("The cello is a bowed string instrument of the violin family.");
    }
}


class Program
{
    static void Main()
    {
        MusicalInstrument violin = new Violin("Violin", "A string instrument with a high pitch");
        MusicalInstrument trombone = new Trombone("Trombone", "A brass instrument with a slide");
        MusicalInstrument ukulele = new Ukulele("Ukulele", "A small, guitar-like instrument");
        MusicalInstrument cello = new Cello("Cello", "A large, low-pitched string instrument");

        MusicalInstrument[] instruments = { violin, trombone, ukulele, cello };

        foreach (var instrument in instruments)
        {
            instrument.Show();
            instrument.Desc();
            instrument.Sound();
            instrument.History();

            Console.WriteLine();
        }
    }
}


/*
Instrument Name: Violin
Description: A string instrument with a high pitch
Violin sound: Screech
The violin, sometimes known as a fiddle, is a wooden string instrument in the violin family.

Instrument Name: Trombone
Description: A brass instrument with a slide
Trombone sound: Blare
The trombone is a brass instrument in the brass family.

Instrument Name: Ukulele
Description: A small, guitar-like instrument
Ukulele sound: Strum
The ukulele is a member of the lute family of instruments.

Instrument Name: Cello
Description: A large, low-pitched string instrument
Cello sound: Deep and rich
The cello is a bowed string instrument of the violin family.


C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 4992) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:
 */