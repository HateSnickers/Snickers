using System;
using System.Text;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadej hodnotu pro n, pouze kladnou (>0)");
            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}" + Environment.NewLine); // Vypsani vysledku uzivateli.

            Console.WriteLine("Pro ukončení stiskni Enter.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
              // Ukončení programu po stisku Enter.
            }
            Console.Clear(); // Vymaže konzoli pro další zadání.
            
        }

        static int Factorial(int n)

        {
            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.         
            if (n <= 0)
            {
                Main();
            }
            if (n < 2) return 1;

            Console.ForegroundColor
           = ConsoleColor.Blue;
            Console.WriteLine($"Ještě nejsem v jednicce, zasouvam se do {n-1}" + Environment.NewLine);
            int nFactorial = n * Factorial(n - 1);

            Console.ForegroundColor
           = ConsoleColor.Green;
            Console.WriteLine($"Pro {n} je nFactorial {nFactorial}"+ Environment.NewLine);

            Console.ForegroundColor
           = ConsoleColor.White;
            return nFactorial;


            // TODO: Uprav, aby Factorial vracel spravnou hodnotu.
        }


        static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

    }
}
