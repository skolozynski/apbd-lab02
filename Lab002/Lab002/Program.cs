// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
for (int i = 0; i < 5; i++)
{
    Console.Write(i);
    Console.WriteLine("*");
}

String cos = "def"; 
cos = Console.ReadLine();
Console.WriteLine(cos);

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach ( var number in numbers)
        sum += number;
    return (double) sum / numbers.Length;
}