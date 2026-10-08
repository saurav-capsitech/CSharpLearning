namespace CSharpLearning;

class Program
{
    static void Main()
    {
        // 1. Array & Sum
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

        // 2. Countdown Loop
        for (int i = 10; i >= 5; i--)
        {
            Console.WriteLine(i);
        }

        // 3. Calculator Object
        Calculator calc = new Calculator();
        Console.WriteLine($"Multiply: {calc.Multiply(5, 4)}");
        Console.WriteLine($"Add: {calc.Add(10, 20)}");

        // 4. Product Object
        Product prod = new Product
        {
            Name = "Laptop",
            Price = 1000m
        };
        prod.ShowPrice();

        // 5. Car Object
        Car myCar = new Car
        {
            Name = "BMW",
            Price = 500000000m
        };
        myCar.ShowDetails();
    }
}
