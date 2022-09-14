using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favourite pizza? ");
            string pizzaFlavour = Console.ReadLine();
            pizzaFlavour = pizzaFlavour.ToLower();

            if (pizzaFlavour == "cheese and tomato" || pizzaFlavour == "margherita")
            {
                Console.WriteLine("Suitable for vegetarians");
            }

            else if(pizzaFlavour == "pepperoni" || pizzaFlavour == "meat feast")
            {
                Console.WriteLine("Contains Meat");
            }

            else
            {
                Console.WriteLine("Unknown pizza, may contain meat");
            }
                
        }
    }
}
