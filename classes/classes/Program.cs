using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        class Human
        {
            private int age;
            public int height;
            public int weight;
            public string hairColor;
            public string eyeColor;
            public string name;

            public Human(int age, int height, int weight)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;

                hairColor = "neznámý/á";
                eyeColor = "neznámý/á";
                name = "neznámý/á";
            }
            public Human(int age, int height, int weight, string hairColor, string eyeColor, string name)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.hairColor = hairColor;
                this.eyeColor = eyeColor;
                this.name = name;
            }

            public void PrintChar()
            {
                string printedName = name;
                if (printedName == null)
                {
                    printedName = "Nepřizpůsobivý/á";
                }
                Console.WriteLine($"{printedName} je starý/á {age} let, měří {height} cm");
            }
            public float BMI()
            {
                float heightForCalc = height / 100f;
                float BMI = (float)weight / (heightForCalc * heightForCalc);
                return BMI;
            }
            public int GetAge()
            {
                return age;
            }
            public void SetAge(int age)
            {
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("tento věk nelze nastavit");
                }
                else
                {
                    this.age = age;
                }
            }
        }
        static void Main(string[] args)
        {
            Human human1 = new Human(32, 165, 65);

            human1.PrintChar();

            Human human2 = new Human(18, 205, 99, "Brown", "Black", "Fero");
            human2.PrintChar();
            float BMI = human2.BMI();
            Console.WriteLine($"{human2.name} má BMI {BMI}");

            Human human3 = new Human(10, 130, 80);
            human3.PrintChar();
            Console.WriteLine($"Dítě má BMI {human3.BMI()}");

            Console.WriteLine(human1.GetAge());

            Console.ReadKey();
        }
    }
}