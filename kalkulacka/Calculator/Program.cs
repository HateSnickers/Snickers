using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            string Text;
            double result = 0;
            Console.WriteLine("Vyberte režim: (1) Desítková, (2) Dvojková, (3) Šestnáctková");
            Text = Console.ReadLine();

            int baseChoice = 10;

            if (Text == "2")
            {
                baseChoice = 2; 
            }
            else if (Text == "3")
            {
                baseChoice = 16; 
            }

            Console.WriteLine("Zadejte první číslo");
            Text = Console.ReadLine();
            double cislo = Convert.ToDouble(Text);

            Console.WriteLine("Zadejte druhé číslo");
            Text = Console.ReadLine();
            double cislo2 = Convert.ToDouble(Text);

            Console.WriteLine("Zadejte operaci");
            Text = Console.ReadLine();
            op = Convert.ToString(Text);

            switch (op)
            {
                case "+":
                    result = cislo + cislo2;
                    break;
                case "-":
                    result = cislo - cislo2;
                    break;
                case "*":
                    result = cislo * cislo2;
                    break;
                case "/":
                    result = cislo / cislo2;
                    break;
                case "mocnina":
                    result = Math.Pow(cislo, cislo2);
                    break;
                case "odmocnina":
                    result = Math.Sqrt(cislo);
                    break;
                case "log":
                    result = Math.Log(cislo);
                    break;
                default:
                    Console.WriteLine("Neplatná operace");
                    break;
            }

            if (baseChoice == 2)
            {
                Console.WriteLine("Výsledek v dvojkové soustavě: " + Convert.ToString((int)result, 2));
            }
            else if (baseChoice == 16)
            {
                Console.WriteLine("Výsledek v šestnáctkové soustavě: " + Convert.ToString((int)result, 16));
            }
            else
            {
                Console.WriteLine("Výsledek v desítkové soustavě: " + result);
            }

            Console.ReadKey();
        }
    }
}