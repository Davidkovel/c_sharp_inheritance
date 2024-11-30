namespace InheritanceApp;


public class Passport
{
    public string FullName { get; set; }
    public string Nationality { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfExpiry { get; set; }

    public Passport(string fullName, string nationality, string passportNumber, DateTime dateOfBirth, DateTime dateOfExpiry)
    {
        FullName = fullName;
        Nationality = nationality;
        PassportNumber = passportNumber;
        DateOfBirth = dateOfBirth;
        DateOfExpiry = dateOfExpiry;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Nationality: {Nationality}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Date of Expiry: {DateOfExpiry.ToShortDateString()}");
    }
}

public class ForeignPassport : Passport
{
    public string ForeignPassportNumber { get; set; }
    public List<string> Visas { get; set; }

    public ForeignPassport(string fullName, string nationality, string passportNumber, DateTime dateOfBirth, DateTime dateOfExpiry, string foreignPassportNumber)
        : base(fullName, nationality, passportNumber, dateOfBirth, dateOfExpiry)
    {
        ForeignPassportNumber = foreignPassportNumber;
        Visas = new List<string>();
    }

    public void AddVisa(string visa)
    {
        Visas.Add(visa);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}\n");
        Console.WriteLine("Visas:");
        foreach (var visa in Visas)
        {
            Console.WriteLine($"- {visa}");
        }
    }
}


class Program
{
    static void Main()
    {
        ForeignPassport foreignPassport = new ForeignPassport("David Bob", "Ukrainian", "3234324324", new DateTime(2025, 8, 24), new DateTime(2300, 9, 25), "434232");
        foreignPassport.AddVisa("Visa USA");

        foreignPassport.DisplayInfo();
    }
}


/*
Full Name: David Bob
Nationality: Ukrainian
Passport Number: 3234324324
Date of Birth: 24.08.2025
Date of Expiry: 25.09.2300
Foreign Passport Number: 434232

Visas:
- Visa USA

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 13408) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

 
*/