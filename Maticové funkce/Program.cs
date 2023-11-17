using System;

namespace Maticové_funkce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvoreni maticove funkce zadanim jejich velikosti stran x a y, respektive a a b
            Console.WriteLine("Zadejte velikost matice:");
            Console.WriteLine("Zadejte velikost strany a (pouze kladné hodnoty):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Zadejte velikost strany b (pouze kladné hodnoty):");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int[,] my2Darray = new int[a, b];
            Console.Write("\n");

            int numberToAdd = 1;
            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    my2Darray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2Darray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            while (true) //Vyber operace, kterou vyuzijeme na nasi maticovou funkci
            {
                Console.WriteLine("Vyberte možnosti: (1) Switch, (2) NumMatrixMulti, (3) PlusMinus, (4) Transposition, (5) MatrixMulti, (6) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        Switch(my2Darray);
                        break;
                    case "2":
                        NumMatrixMulti();
                        break;
                    case "3":
                        PlusMinus();
                        break;
                    case "4":
                        Transposition();
                        break;
                    case "5":
                        MatrixMulti();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Toto je neplatná hodnota");
                        break;
                }
            }
        }

        public static void Switch(int[,] my2Darray)
        {
            while (true)
            {
                Console.WriteLine("Vyberte možnosti: (1) řádek, (2) sloupek, (3) hl.diagonala, (4) vd. diagonala, (5) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        lane(my2Darray);
                        break;
                    case "2":
                        column(my2Darray);
                        break;
                    case "3":
                        maindiagonal(my2Darray);
                        break;
                    case "4":
                        secondarydiagonal(my2Darray);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Toto je neplatná hodnota");
                        break;
                }
            }
        }

        public static void lane(int[,] my2Darray)
        {
            Console.WriteLine("Zadejte číslo řádku, které chcete prohodit (v rozsahu 0 - {0}):", my2Darray.GetLength(0) - 1);
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0 || a >= my2Darray.GetLength(0))
            {
                Console.WriteLine("Neplatná hodnota řádku. Zadejte hodnotu v platném rozsahu.");
                return;
            }

            Console.WriteLine("Zadejte hodnotu druhého řádku (v rozsahu 0 - {0}):", my2Darray.GetLength(0) - 1);
            int b = Convert.ToInt32(Console.ReadLine());

            if (b < 0 || b >= my2Darray.GetLength(0) || b == a)
            {
                Console.WriteLine("Neplatná hodnota druhého řádku. Zadejte jinou hodnotu v platném rozsahu.");
                return;
            }

            int nRowSwap = a;
            int mRowSwap = b;
            int[] tempArray = new int[my2Darray.GetLength(1)];
            int numberToAdd = 1;

            for (int j = 0; j < my2Darray.GetLength(1); j++)
            {
                tempArray[j] = my2Darray[nRowSwap, j];
            }

            for (int j = 0; j < my2Darray.GetLength(1); j++)
            {
                my2Darray[nRowSwap, j] = my2Darray[mRowSwap, j];
            }

            for (int j = 0; j < my2Darray.GetLength(1); j++)
            {
                my2Darray[mRowSwap, j] = tempArray[j];
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    numberToAdd++;
                    Console.Write(my2Darray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void column(int[,] my2Darray)
        {
            Console.WriteLine("Zadejte číslo sloupce, které chcete prohodit (v rozsahu 0 - {0}):", my2Darray.GetLength(1) - 1);
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0 || a >= my2Darray.GetLength(1))
            {
                Console.WriteLine("Neplatná hodnota sloupce. Zadejte hodnotu v platném rozsahu.");
                return;
            }

            Console.WriteLine("Zadejte hodnotu druhého sloupce (v rozsahu 0 - {0}):", my2Darray.GetLength(1) - 1);
            int b = Convert.ToInt32(Console.ReadLine());

            if (b < 0 || b >= my2Darray.GetLength(1) || b == a)
            {
                Console.WriteLine("Neplatná hodnota druhého sloupce. Zadejte jinou hodnotu v platném rozsahu.");
                return;
            }

            int nColSwap = a;
            int mColSwap = b;
            int[] tempArrayColumn = new int[my2Darray.GetLength(0)];
            int numberToAdd = 1;

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                tempArrayColumn[i] = my2Darray[i, nColSwap];
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                my2Darray[i, nColSwap] = my2Darray[i, mColSwap];
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                my2Darray[i, mColSwap] = tempArrayColumn[i];
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    numberToAdd++;
                    Console.Write(my2Darray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void maindiagonal(int[,] my2Darray)
        {
            int numberToAdd = 1;
            for (int i = 0; i < my2Darray.GetLength(0) / 2; i++)
            {
                int temp = my2Darray[i, i];
                int reversedIndex = my2Darray.GetLength(0) - i - 1;
                my2Darray[i, i] = my2Darray[reversedIndex, reversedIndex];
                my2Darray[reversedIndex, reversedIndex] = temp;
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    numberToAdd++;
                    Console.Write(my2Darray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void secondarydiagonal(int[,] my2Darray)
        {
            int numberToAdd = 1;
            int n = my2Darray.GetLength(0);

            for (int i = 0; i < n / 2; i++)
            {
                int temp = my2Darray[i, n - i - 1];
                my2Darray[i, n - i - 1] = my2Darray[n - i - 1, i];
                my2Darray[n - i - 1, i] = temp;
            }

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    numberToAdd++;
                    Console.Write(my2Darray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void NumMatrixMulti()
        {
            // Implementace pro násobení matic
        }

        public static void PlusMinus()
        {
            // Implementace pro sčítání a odčítání matic
        }

        public static void Transposition()
        {
            // Implementace pro transpozici matice
        }

        public static void MatrixMulti()
        {
            // Implementace pro násobení matic
        }
    }
}
