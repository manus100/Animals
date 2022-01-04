using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog("Sharo", 132,"Male");
 
            Console.WriteLine(GetAnimalType(dog.GetType().ToString()));
            Console.WriteLine($"{dog.Name} {dog.Age} {dog.Gender}");
            Console.WriteLine(dog.ProduceSound());

            Console.WriteLine();
            Frog frog = new Frog("Kermit", 12, "Male");
            Console.WriteLine(GetAnimalType(frog.GetType().ToString()));
            Console.WriteLine($"{frog.Name} {frog.Age} {frog.Gender}");
            Console.WriteLine(frog.ProduceSound());

            Console.WriteLine();
            Cat cat = new Cat("Tom", 12, "Male");
            Console.WriteLine(GetAnimalType(cat.GetType().ToString()));
            Console.WriteLine($"{cat.Name} {cat.Age} {cat.Gender}");
            Console.WriteLine(cat.ProduceSound());

            Console.WriteLine();
            Cat kitten = new Kitten("Missy", 1);
            Console.WriteLine(GetAnimalType(kitten.GetType().ToString()));
            Console.WriteLine($"{kitten.Name} {kitten.Age} {kitten.Gender}");
            Console.WriteLine(kitten.ProduceSound());

            Console.WriteLine();
            Cat tomcat = new Tomcat("Ricky", 5);
            Console.WriteLine(GetAnimalType(tomcat.GetType().ToString()));
            Console.WriteLine($"{tomcat.Name} {tomcat.Age} {tomcat.Gender}");
            Console.WriteLine(tomcat.ProduceSound());


            Console.ReadLine();

             string GetAnimalType(string str)
            {
                return str.Substring(str.LastIndexOf(".") + 1, str.Length - str.LastIndexOf(".") - 1);
            }

            //string gender;
            //string name;
            //int age;
            //string type;


            //while (Console.ReadLine() != "Beast!")
            //{
            //    if (GetAnimalType(Console.ReadLine()) is Cat)
            //    {

            //    }
            //}

        }
    }
}
