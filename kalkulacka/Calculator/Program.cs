using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vyberte režim: (1) Desítková, (2) Dvojková, (3) Kalkulačka, (4) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        DecimalMode();
                        break;
                    case "2":
                        BinaryMode();
                        break;
                    case "3":
                        CalculatorMode();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Toto je neplatná hodnota");
                        break;
                }
            }
        }

        public static void DecimalMode()
        {
            Console.WriteLine("Decimal mode ještě není zhotoven.");
        }

        public static void BinaryMode()
        {
            Console.WriteLine("Zadejte číslo");
            int num = Convert.ToInt32(Console.ReadLine());
            string binaryResult = Convert.ToString(num, 2);
            Console.WriteLine("Binary Result: " + binaryResult);
            Console.ReadKey();
            Console.Clear();
        }

        public static void CalculatorMode()
        {
            string op = "";
            string Text = "";
            double result = 0;

            string pokracovat = "ano";
            while (pokracovat == "ano")
            {
                Console.WriteLine("Zadejte první číslo");
                Text = Console.ReadLine();
                double cislo;
                if (!double.TryParse(Text, out cislo))
                {
                    Console.WriteLine("Neplatné číslo, zadejte znovu.");
                    continue;
                }

                Console.WriteLine("Zadejte druhé číslo");
                Text = Console.ReadLine();
                double cislo2;
                if (!double.TryParse(Text, out cislo2))
                {
                    Console.WriteLine("Neplatné číslo, zadejte znovu.");
                    continue;
                }

                Console.WriteLine("Zadejte operaci (1)+,(2)-,(3)*,(4)/,(5)mocnina,(6)odmocnina,(7)log");
                Text = Console.ReadLine();
                op = Text;

                switch (op)
                {
                    case "1":
                        result = cislo + cislo2;
                        break;
                    case "2":
                        result = cislo - cislo2;
                        break;
                    case "3":
                        result = cislo * cislo2;
                        break;
                    case "4":
                        if (cislo2 == 0)
                        {
                            Console.WriteLine("Nelze dělit nulou.");
                            continue;
                        }
                        result = cislo / cislo2;
                        break;
                    case "5":
                        result = Math.Pow(cislo, cislo2);
                        break;
                    case "6":
                        if (cislo < 0)
                        {
                            Console.WriteLine("Odmocnina záporného čísla není definována.");
                            continue;
                        }
                        result = Math.Sqrt(cislo);
                        break;
                    case "7":
                        if (cislo <= 0)
                        {
                            Console.WriteLine("Logaritmus záporného nebo nulového čísla není definován.");
                            continue;
                        }
                        result = Math.Log(cislo);
                        break;
                    default:
                        Console.WriteLine("Neplatná operace");
                        break;
                }

                Console.WriteLine($"Výsledek: {result}");
                pokracovat = Console.ReadLine();
            }
        }
    }
}
