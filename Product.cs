namespace CSharpLearning;

public class Product
{
    // Properties only - NO constructor written here!
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void ShowPrice()
    {
        Console.WriteLine($"{Name} Price: {Price}");
    }
}


class Program
{
    static void Main()
    {
        int result = Multiply(5, 4);

        Console.WriteLine(result);
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}

