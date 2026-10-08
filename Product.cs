namespace CSharpLearning;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void ShowPrice()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Multiply(int a, int b) => a * b;
}

public class Car
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Car: {Name}, Price: {Price}");
    }
}
