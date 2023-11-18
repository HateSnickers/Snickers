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
                    Console.Write(my2Darray[i, j] + " ");//vypsani vytvorene matice
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            while (true) //Vyber operace, kterou vyuzijeme na nasi maticovou funkci
            {
                Console.WriteLine("Vyberte možnosti: (1) Switch, (2) NumMatrixMulti, (3) PlusMinus, (4) Transposition, (5) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        Switch(my2Darray);
                        break;
                    case "2":
                        NumMatrixMulti(my2Darray);
                        break;
                    case "3":
                        PlusMinus(my2Darray);
                        break;
                    case "4":
                        Transposition(my2Darray);
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

        public static void Switch(int[,] my2Darray) //funkce pro prohazovani jednotlivych casti matice
        {
            while (true)
            {
                Console.WriteLine("Vyberte možnosti: (1) řádek, (2) sloupek, (3) hl.diagonala, (4) vd. diagonala, (5) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        lane(my2Darray); //radek
                        break;
                    case "2":
                        column(my2Darray); //sloupek
                        break;
                    case "3":
                        maindiagonal(my2Darray); //hl diagonala
                        break;
                    case "4":
                        secondarydiagonal(my2Darray); //vd diagonala
                        break;
                    case "5":
                        Environment.Exit(0); //konec
                        break;
                    default:
                        Console.WriteLine("Toto je neplatná hodnota"); //pripadna chyba a zopakovani vyberu, proto cyklus while
                        break;
                }
            }
        }

        public static void lane(int[,] my2Darray) //prohozeni radku 
        {
            Console.WriteLine("Zadejte číslo řádku, které chcete prohodit (v rozsahu 0 - {0}):", my2Darray.GetLength(0) - 1);
            int a = Convert.ToInt32(Console.ReadLine()); //vyber radku a 

            if (a < 0 || a >= my2Darray.GetLength(0))
            {
                Console.WriteLine("Neplatná hodnota řádku. Zadejte hodnotu v platném rozsahu.");
                return; //pripadna chyba a znovuzadani
            }

            Console.WriteLine("Zadejte hodnotu druhého řádku (v rozsahu 0 - {0}):", my2Darray.GetLength(0) - 1);
            int b = Convert.ToInt32(Console.ReadLine()); //zadani radku b

            if (b < 0 || b >= my2Darray.GetLength(0) || b == a)
            {
                Console.WriteLine("Neplatná hodnota druhého řádku. Zadejte jinou hodnotu v platném rozsahu.");
                return; //pripadna chyba a znovuzadani
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
            Console.Write("\n");//vypsani matice s prohozenymi radky
        }

        public static void column(int[,] my2Darray) //prohozeni sloupku
        {
            Console.WriteLine("Zadejte číslo sloupce, které chcete prohodit (v rozsahu 0 - {0}):", my2Darray.GetLength(1) - 1);
            int a = Convert.ToInt32(Console.ReadLine()); //vybereme sloupek a

            if (a < 0 || a >= my2Darray.GetLength(1))
            {
                Console.WriteLine("Neplatná hodnota sloupce. Zadejte hodnotu v platném rozsahu.");
                return; //pripadne znovuzadani pri chybe
            }

            Console.WriteLine("Zadejte hodnotu druhého sloupce (v rozsahu 0 - {0}):", my2Darray.GetLength(1) - 1);
            int b = Convert.ToInt32(Console.ReadLine()); //zadame sloupek b 

            if (b < 0 || b >= my2Darray.GetLength(1) || b == a)
            {
                Console.WriteLine("Neplatná hodnota druhého sloupce. Zadejte jinou hodnotu v platném rozsahu.");
                return; //pripadne znovuzadani pri chybe
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
            Console.Write("\n"); //vypsani
        }

        public static void maindiagonal(int[,] my2Darray) //hl diagonala prohozeni 
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
            Console.Write("\n"); //vypsani
        }

        public static void secondarydiagonal(int[,] my2Darray) //vd diagonala prohozeni
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
            Console.Write("\n"); //vypsani
        }

        public static void NumMatrixMulti(int[,] my2Darray) //vynasobeni matice zadanym cislem
        {
            Console.WriteLine("Zadejte konstantu, kterou chcete násobit matici:");
            int constant = Convert.ToInt32(Console.ReadLine()); //zde vybereme cislo ketrym chceme matici vynasobit
            Console.Write("\n");

            int numberToAdd = 1;
            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    my2Darray[i, j] *= constant; //vynasobeni matice s nami vybranym cislem
                    Console.Write(my2Darray[i, j] + " ");
                    numberToAdd++;
                }
                Console.Write("\n");
            }
            Console.Write("\n"); //vypsani
        }

        public static void PlusMinus(int[,] my2Darray) //pridani / odecteni cisla od matice
        {
            while (true)
            {
                Console.WriteLine("Vyberte možnosti: (1) přičíst, (2) odečíst, (3) Ukončit");
                string funkce = Console.ReadLine();

                switch (funkce)
                {
                    case "1":
                        Plus(my2Darray);
                        break;
                    case "2":
                        Minus(my2Darray);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Toto je neplatná hodnota");
                        break;
                }
            }
        }
        public static void Plus(int[,] my2Darray) //rpicitani k matici 
        {
            Console.WriteLine("Zadejte konstantu, kterou chcete přidat od matice:");
            int constant = Convert.ToInt32(Console.ReadLine()); //zde si vybereme cislo ktere chceme k matici pridat
            Console.Write("\n");

            int numberToAdd = 1;
            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    my2Darray[i, j] = my2Darray[i, j] + constant; //zde se cislo k matici prida

                    Console.Write(my2Darray[i, j] + " ");
                    numberToAdd++;
                }
                Console.Write("\n");
            }
            Console.Write("\n"); //vypsani do konzole
        }
        public static void Minus(int[,] my2Darray) //odcitani od matice
        {
            Console.WriteLine("Zadejte konstantu, kterou chcete odebrat od matice:");
            int constant = Convert.ToInt32(Console.ReadLine()); //vybirime cislo, ktere si prejeme od matici odecist
            Console.Write("\n");

            int numberToAdd = 1;
            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    my2Darray[i, j] = my2Darray[i, j] - constant; //ude se odecte cislo od matice 

                    Console.Write(my2Darray[i, j] + " ");
                    numberToAdd--;
                }
                Console.Write("\n");
            }
            Console.Write("\n"); //vypsani do konzole
        }

        public static void Transposition(int[,] my2Darray) // prepis matice do sloupove orientovane roviny
        {
            int[,] transArray = new int[my2Darray.GetLength(1), my2Darray.GetLength(0)]; //nacteni puvodni matice

            for (int i = 0; i < my2Darray.GetLength(0); i++) //prochazeni puvodni matice a otoceni na transponovanou matici
            {
                for (int j = 0; j < my2Darray.GetLength(1); j++)
                {
                    transArray[j, i] = my2Darray[i, j]; //otoceni matice
                }
            }

            Console.WriteLine("Transponovaná matice:"); 
            int numberToAdd = 1;
            for (int i = 0; i < transArray.GetLength(0); i++)
            {
                for (int j = 0; j < transArray.GetLength(1); j++)
                {
                    Console.Write(transArray[i, j] + " ");
                    numberToAdd++;
                }
                Console.Write("\n");
            }
            Console.Write("\n");//vypis do konzole
        }
    }
}