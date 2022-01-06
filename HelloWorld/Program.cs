using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please enter your name: ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("What is your age? ");
            int age;
            age = Int16.Parse(Console.ReadLine());
            Console.WriteLine("OK " + name + " is your age really " + age + "?");
            float weight;
            Console.Write("OK " + name + " what is your weight? ");
            weight = (float)Double.Parse(Console.ReadLine());
            Console.WriteLine("OK " + name + " is your weight really " + weight + "?");
            Console.ReadLine();

        }
    }
}
