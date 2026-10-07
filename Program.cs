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