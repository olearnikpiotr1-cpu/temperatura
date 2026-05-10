using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz kierunek konwersji (C/F): ");
        string wybor = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        double wynik;

        if (wybor == "C")
        {
            wynik = (temp * 9 / 5) + 32;
            Console.WriteLine(temp + "°C = " + wynik + "°F");
        }
        else if (wybor == "F")
        {
            wynik = (temp - 32) / 1.8;
            Console.WriteLine(temp + "°F = " + wynik + "°C");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór!");
        }
    }
}