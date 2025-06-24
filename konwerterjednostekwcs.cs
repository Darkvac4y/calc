using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Witamy w konwerterze jednostek!\n");
            Console.WriteLine("Wybierz kategorię jednostek:");
            Console.WriteLine("1. - Temperatura");
            Console.WriteLine("2. - Czas");
            Console.WriteLine("3. - Masa");
            Console.WriteLine("4. - Pamięć komputerowa");

            Console.Write("\nTwój wybór: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    PrzeliczTemperature();
                    break;
                case "2":
                    PrzeliczCzas();
                    break;
                case "3":
                    PrzeliczMase();
                    break;
                case "4":
                    PrzeliczPamiec();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć.");
            Console.ReadKey();
        }

        static void PrzeliczTemperature()
        {
            string[] jednostki = { "Celsjusz", "Fahrenheit", "Kelvin" };

            Console.WriteLine("\nWybierz jednostkę wejściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            string jednostka1 = Console.ReadLine();

            Console.WriteLine("\nWybierz jednostkę wyjściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            string jednostka2 = Console.ReadLine();

            Console.Write("\nPodaj wartość: ");
            if (!double.TryParse(Console.ReadLine(), out double wartosc))
            {
                Console.WriteLine("Nieprawidłowa wartość.");
                return;
            }

            if (jednostka1 == jednostka2)
            {
                Console.WriteLine($"Wynik: {wartosc} {jednostki[int.Parse(jednostka1) - 1]}");
                return;
            }

            double wynik = 0;

            if (jednostka1 == "1" && jednostka2 == "2")
                wynik = (wartosc * 9 / 5) + 32;
            else if (jednostka1 == "1" && jednostka2 == "3")
                wynik = wartosc + 273.15;
            else if (jednostka1 == "2" && jednostka2 == "1")
                wynik = (wartosc - 32) * 5 / 9;
            else if (jednostka1 == "2" && jednostka2 == "3")
                wynik = (wartosc - 32) * 5 / 9 + 273.15;
            else if (jednostka1 == "3" && jednostka2 == "1")
                wynik = wartosc - 273.15;
            else if (jednostka1 == "3" && jednostka2 == "2")
                wynik = (wartosc - 273.15) * 9 / 5 + 32;

            Console.WriteLine($"\nWynik: {wartosc} {jednostki[int.Parse(jednostka1) - 1]} = {wynik} {jednostki[int.Parse(jednostka2) - 1]}");
        }

        static void PrzeliczCzas()
        {
            string[] jednostki = { "sekunda", "minuta", "godzina", "dzień", "miesiąc" };
            double[] mnozniki = { 1, 60, 3600, 86400, 2592000 };

            Console.WriteLine("\nWybierz jednostkę wejściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\nWybierz jednostkę wyjściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index2 = int.Parse(Console.ReadLine()) - 1;

            Console.Write("\nPodaj wartość: ");
            if (!double.TryParse(Console.ReadLine(), out double wartosc))
            {
                Console.WriteLine("Nieprawidłowa wartość.");
                return;
            }

            double wSekundach = wartosc * mnozniki[index1];
            double wynik = wSekundach / mnozniki[index2];

            Console.WriteLine($"\nWynik: {wartosc} {jednostki[index1]} = {wynik} {jednostki[index2]}");
        }

        static void PrzeliczMase()
        {
            string[] jednostki = { "miligram", "gram", "kilogram", "tona" };
            double[] mnozniki = { 0.001, 1, 1000, 1000000 }; // wszystkie w gramach

            Console.WriteLine("\nWybierz jednostkę wejściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\nWybierz jednostkę wyjściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index2 = int.Parse(Console.ReadLine()) - 1;

            Console.Write("\nPodaj wartość: ");
            if (!double.TryParse(Console.ReadLine(), out double wartosc))
            {
                Console.WriteLine("Nieprawidłowa wartość.");
                return;
            }

            double wGramach = wartosc * mnozniki[index1];
            double wynik = wGramach / mnozniki[index2];

            Console.WriteLine($"\nWynik: {wartosc} {jednostki[index1]} = {wynik} {jednostki[index2]}");
        }

        static void PrzeliczPamiec()
        {
            string[] jednostki = { "bit", "gigabajt", "gigabit", "kilobajt", "kilobit" };
            double[] mnozniki = {
                1,                     // bit
                8_589_934_592,         // gigabajt (1 GB = 1024^3 * 8 bits)
                1_073_741_824,         // gigabit
                8_192,                 // kilobajt (1024 * 8)
                1_024                  // kilobit
            };

            Console.WriteLine("\nWybierz jednostkę wejściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\nWybierz jednostkę wyjściową:");
            for (int i = 0; i < jednostki.Length; i++)
                Console.WriteLine($"{i + 1}. - {jednostki[i]}");

            Console.Write("Twój wybór: ");
            int index2 = int.Parse(Console.ReadLine()) - 1;

            Console.Write("\nPodaj wartość: ");
            if (!double.TryParse(Console.ReadLine(), out double wartosc))
            {
                Console.WriteLine("Nieprawidłowa wartość.");
                return;
            }

            double wBitach = wartosc * mnozniki[index1];
            double wynik = wBitach / mnozniki[index2];

            Console.WriteLine($"\nWynik: {wartosc} {jednostki[index1]} = {wynik} {jednostki[index2]}");
        }
    }
}
