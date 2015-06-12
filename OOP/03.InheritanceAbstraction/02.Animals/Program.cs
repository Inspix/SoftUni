using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rexy",25,"male");
            Console.WriteLine(dog);
            Console.WriteLine("Press any key to hear Rexy bark..");
            Console.ReadKey();
            dog.ProduceSound();
            Console.WriteLine(Environment.NewLine);
            Frog frog = new Frog("Anabel", 25, "female");
            Console.WriteLine(frog);
            Console.WriteLine("Press any key to hear Anabel creek..");
            Console.ReadKey();
            frog.ProduceSound();
            Console.WriteLine(Environment.NewLine);
            Tomcat tomcat = new Tomcat("Spot", 25);
            Console.WriteLine(tomcat);
            Console.WriteLine("Press any key to hear Spot meow..");
            Console.ReadKey();
            tomcat.ProduceSound();
            Console.WriteLine(Environment.NewLine);
            Kitten kitten = new Kitten("Cassandra", 15);
            Console.WriteLine(kitten);
            Console.WriteLine("Press any key to hear Cassandra bark..");
            Console.ReadKey();
            kitten.ProduceSound();
        }
    }
}
