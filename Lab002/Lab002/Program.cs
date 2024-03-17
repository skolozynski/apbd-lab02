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
1. Stwórz nową gałąź feature-new
2. Następnie będąc na nowo powstałej gałęzi spróbujzmodyfikować pętle pętle odpowiadającą za wyliczenie średniej.Możesz np. zmienić nazwę zmiennej wykorzystywanej w ramachpętli.
3. Następnie wykonaj commit na gałęzi feature-new.
4. W kolejnym kroku przełącz się na gałąź main i wykonaj innąmodyfikację tej samej pętli. Możesz np. zmienić nazwę zmiennejna jeszcze inną metodę.
5. Wykonaj commit na gałęzi main.
6. W ten sposób obie gałęzie różnią się między sobą. Dodatkowomodyfikowaliśmy ten sam kod na obu gałęziach. Taka sytuacjapowinna doprowadzić do konfliktu.
7. Spróbuj wykonać merge swojej gałęzi z gałęzią main. Rozwiążkonflikt. Wykonaj push zmian na GitHub.
8. Na koniec sprawdź historię swojego repozytorium poprzezkomendę git log.
*/
