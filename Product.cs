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