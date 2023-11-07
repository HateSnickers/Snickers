using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).

            //i jsou radky, j jsou sloupce

            int[,] my2Darray = new int[5, 5];
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
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            for (int j = 0; j < my2Darray.GetLength(1); j++)
            {
                Console.Write(my2Darray[nRow, j]);
            }
            Console.Write("\n");
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                Console.Write(my2Darray[i, nColumn]);
            }
            Console.Write("\n");

            //Diagonaly [4,0][3,1][2,2][1,3][0,4]
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(my2Darray[i, my2Darray.GetLength(0) - i - 1] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 1;
            //int first = my2Darray[xFirst, yFirst];
            //int second = my2Darray[xSecond, ySecond];
            int temp = my2Darray[xFirst, yFirst];
            my2Darray[xFirst, yFirst] = my2Darray[xSecond, ySecond];
            my2Darray[xSecond, ySecond] = temp;

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
            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int[] tempArray = new int[5];

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


            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int[] tempArrayColumn = new int[5];

            for (int i = 0; i < my2Darray.GetLength(0); i++)
            {
                tempArrayColumn[i] = my2Darray[i , nColSwap];
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



            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 0; i <= my2Darray.GetLength(0) / 2;i++)
            {
                int tempsecond = my2Darray[i, i];
                int reversedIndex = my2Darray.GetLength(0) - i - 1;
                my2Darray[i, i] = my2Darray[reversedIndex, reversedIndex];
                my2Darray[reversedIndex, reversedIndex] = tempsecond;
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
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(my2Darray[i, my2Darray.GetLength(0) - i - 1] + " ");
            }

            for (int i = 4; i > my2Darray.GetLength(0) / 2; i--)
            {
                int tempsecond = my2Darray[i, my2Darray.GetLength(0) - i - 1];
                int j = my2Darray.GetLength(0) - i - 1;
                my2Darray[i, j] = my2Darray[j, i];
                my2Darray[j, i] = tempsecond;
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


































            Console.ReadKey();
        }
    }
}
