using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vítejte u rulety!");

        while (true)
        {
            Console.WriteLine("1 - Sázet na číslo");
            Console.WriteLine("2 - Sázet na barvu");
            Console.WriteLine("3 - Konec hry");
            Console.Write("Vyberte možnost: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PlayNumberBet();
                        break;
                    case 2:
                        PlayColorBet();
                        break;
                    case 3:
                        Console.WriteLine("Konec hry. Děkujeme za hraní!");
                        return;
                    default:
                        Console.WriteLine("Neplatná volba. Zadejte znovu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Neplatná volba. Zadejte znovu.");
            }
        }
    }

    static void PlayNumberBet()
    {
        Console.Write("Zadejte číslo, na které chcete vsadit (0-36): ");
        int betNumber;
        if (int.TryParse(Console.ReadLine(), out betNumber) && betNumber >= 0 && betNumber <= 36)
        {
            Console.Write("Zadejte výši sázky: ");
            int betAmount;
            if (int.TryParse(Console.ReadLine(), out betAmount) && betAmount > 0)
            {
                int winningNumber = new Random().Next(37);
                Console.WriteLine("Padlo číslo: " + winningNumber);
                if (betNumber == winningNumber)
                {
                    int winnings = betAmount * 36;
                    Console.WriteLine("Gratulujeme! Vyhráli jste " + winnings + " žetonů.");
                }
                else
                {
                    Console.WriteLine("Smůla, prohráli jste.");
                }
            }
            else
            {
                Console.WriteLine("Neplatná sázka. Zadejte kladné číslo.");
            }
        }
        else
        {
            Console.WriteLine("Neplatné číslo. Zadejte číslo mezi 0 a 36.");
        }
    }

    static void PlayColorBet()
    {
        Console.Write("Zadejte barvu, na kterou chcete vsadit (červená/černá): ");
        string betColor = Console.ReadLine();
        if (betColor.ToLower() == "červená" || betColor.ToLower() == "černá")
        {
            Console.Write("Zadejte výši sázky: ");
            int betAmount;
            if (int.TryParse(Console.ReadLine(), out betAmount) && betAmount > 0)
            {
                string[] colors = { "červená", "černá" };
                string winningColor = colors[new Random().Next(2)];
                Console.WriteLine("Padla barva: " + winningColor);
                if (betColor.ToLower() == winningColor)
                {
                    int winnings = betAmount * 2;
                    Console.WriteLine("Gratulujeme! Vyhráli jste " + winnings + " žetonů.");
                }
                else
                {
                    Console.WriteLine("Smůla, prohráli jste.");
                }
            }
            else
            {
                Console.WriteLine("Neplatná sázka. Zadejte kladné číslo.");
            }
        }
        else
        {
            Console.WriteLine("Neplatná barva. Zadejte 'červená' nebo 'černá'.");
        }
    }
}
