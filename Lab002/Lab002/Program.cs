// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

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

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int maximum = numbers[0];
    foreach (int n in numbers)
    {
        if (n > maximum)
            maximum = n;
    }
    return maximum;
}

// TODO:
/*
1. Stwórz nowy branch feature-max
2. Następnie zaimplementuj opisaną funkcjonalność dodająccommit'y na branch
3. Na koniec wykonaj merge swojej gałęzi do gałęzi main. Tymrazem spróbuj wykonać merge wykorzystując rebase.
4. Z pomocą komendy git log sprawdź jak wygląda historiarepozytorium
5. Wszystkie zmiany powinny zostać wypchnięte do repozytoriumonline
*/
