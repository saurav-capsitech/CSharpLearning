using CSharpLearning;

int[] numbers = { 10, 20, 30, 40, 50 };

int sum = 0; ;

foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum: " + sum);


for (int i = 10; i >= 5; i--)
{
    Console.WriteLine(i);
}




Calculator calc = new Calculator();

int result = calc.Add(10, 20);

Console.WriteLine(result);



product prod = new product();
prod.name = "laptop";
prod.price = 1000;

Console.WriteLine($"Product: {prod.name}, Price: {prod.price}");
class product
{
    public string name;
    public int price;
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}



