using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] MyArray = { 1, 2, 3, 4, 5 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Vypsání Foreach cyklem:");

            foreach (int number in MyArray)
                Console.WriteLine(number);

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach (int number in MyArray)
                sum += number;
            Console.WriteLine("Součet řady je " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = 0;
            average = sum / MyArray.Length;
            Console.WriteLine("Průměr řady je " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            max= MyArray.Max();
            Console.WriteLine("Maximum řady je " + max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = 0;
            min= MyArray.Min();
            Console.WriteLine("Minimum řady je " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("Zadejte hledanou hodnotu indexu");
            bool foundNumber = false;
            int userNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < MyArray.Length; i++)
            {
                if(userNumber == MyArray[i])
                {
                    foundNumber = true;
                    Console.WriteLine($"Hledané číslo: {userNumber} je na indexu {i}");
                }
            }
            if(foundNumber == false)
            {
                Console.WriteLine($"Hledané číslo {userNumber} v seznamu neexistuje");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random random = new Random();
            MyArray = new int[100];
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = random.Next(0, 10);
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int number in MyArray)
            {
                counts[number]++;
            }
            for (int i = 0;i < counts.Length;i++) 
            {
            Console.WriteLine($"Číslo {i} se vyskytuje {counts[i]} krát ");
            }
            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] mySecondArray= new int[100];
            for(int i = 0; i < MyArray.Length - 1 ; i++) 
            {
                mySecondArray[mySecondArray.Length - 1 - i] = MyArray[i];
            }
            Console.WriteLine("Prvni pole");
            foreach (int number in MyArray)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
