namespace InheritanceApp;

public interface IMoney
{
    void SetAmount(int wholePart, int fractionalPart);
    void DisplayAmount();
}

public class Money : IMoney
{
    protected int WholePart { get; set; }
    protected int FractionalPart { get; set; }

    public Money()
    {
        WholePart = 0;
        FractionalPart = 0;
    }

    public Money(int wholePart, int fractionalPart) : this()
    {
        SetAmount(wholePart, fractionalPart);
    }

    public void SetAmount(int wholePart, int fractionalPart)
    {
        if (fractionalPart >= 100 || fractionalPart < 0)
            throw new ArgumentException("Fractional part must be between 0 and 99.");

        WholePart = wholePart;
        FractionalPart = fractionalPart;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Amount: {WholePart}.{FractionalPart:D2}");
    }
}

public class Product : Money
{
    public string ProductName { get; set; }

    public Product(string productName, int wholePart, int fractionalPart)
        : base(wholePart, fractionalPart)
    {
        ProductName = productName;
    }

    public void ReducePrice(int wholeReduction, int fractionalReduction)
    {
        int totalCents = (WholePart * 100 + FractionalPart) -
                         (wholeReduction * 100 + fractionalReduction);

        if (totalCents < 0)
        {
            Console.WriteLine("Price reduction exceeds the current price. Setting price to 0.");
            WholePart = 0;
            FractionalPart = 0;
        }
        else
        {
            WholePart = totalCents / 100;
            FractionalPart = totalCents % 100;
        }
    }

    public new void DisplayAmount()
    {
        Console.WriteLine($"Product: {ProductName}, Price: {WholePart}.{FractionalPart:D2}");
    }
}


class Program
{
    static void Main()
    {
        Money money = new Money(100, 20);
        money.DisplayAmount();

        Product product = new Product("Laptop", 200, 20);
        product.DisplayAmount();

        product.ReducePrice(120, 80);
        product.DisplayAmount();
    }
}


/*
Amount: 100.20
Product: Laptop, Price: 200.20
Product: Laptop, Price: 79.40

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 5736) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:


*/
