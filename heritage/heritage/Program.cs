using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangerement;
            public virtual void AnimalNoise()
            {
                Console.WriteLine("Crack yeah !");
            }
        }
        
        class Dog : Animal
        {
            public int numberOfPuppies;
            public string race;
            public override void AnimalNoise()
            {
                Console.WriteLine("PUT YOUR HANDS UP YOU BIGGOT !");
            }
        }
        class Cat : Animal
        {
            public int FurColor;
            public string race;
            public override void AnimalNoise()
            {
                Console.WriteLine("SIR PUT YOUR HANDS OUT OF THE VEHICLE !");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "Fero";
            dog.race = "Bulldog";
            dog.AnimalNoise();
            Console.WriteLine($"{dog.name}, {dog.race} ");

            Cat cat = new Cat();
            cat.name = "Lakatos";
            cat.race = "černá";
            cat.AnimalNoise();
            Console.WriteLine($"{cat.name}, {cat.race} ");

            cat.AnimalNoise();
            dog.AnimalNoise();

            //Animal newAnimal = new Dog();
            //newAnimal.AnimalNoise();
            
            Console.ReadKey();
        }
    }
}
