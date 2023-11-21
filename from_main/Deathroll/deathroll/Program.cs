using System;

namespace deathroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte ve hře Deathroll!");
            Console.WriteLine("Cílem je házet kostkou a vyhnout se hodnotě 1.");

            Random random = new Random();
            int sazka;
            
            Console.WriteLine("Zadej sázku");
            int.TryParse(Console.ReadLine(), out sazka);
            int currentBet = sazka; // Počáteční sázka

            while (true)
            {
                Console.WriteLine($"Aktuální sázka: {currentBet}");
                Console.WriteLine("Stiskněte Enter pro hod kostkou...");
                Console.ReadLine();

                int roll = random.Next(1, sazka);
                Console.WriteLine($"Hráč hodil: {roll}");

                if (roll == 1)
                {
                    Console.WriteLine($"Hráč hodil 1 a prohrál sázkou {currentBet}!");
                    break;
                }

                // Snížení sázky na polovinu po každém úspěšném hodu
                currentBet /= 2;
                roll = random.Next (1, sazka /= 2);
            }

            Console.WriteLine("Děkujeme za hraní Deathroll!");
        }
    }
}
