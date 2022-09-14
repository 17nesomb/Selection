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

            string pizzaFlavour = Input("What pizza would you like? ");
            pizzaFlavour = pizzaFlavour.ToLower();



            switch(pizzaFlavour)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for Vegetarians");
                    break;

                case "pepperoni":
                case "meat feast":
                    Console.WriteLine("Contains meat");
                    break;

                default:
                    Console.WriteLine("Unknown, May contain meat");
                    break;
            }

            string musicGenre = Input("What genre of music is your favourite? ");

            switch(musicGenre)
            {
                case "rock":
                case "indie":

                    Console.WriteLine("Youre cool, i like you");
                    break;

                case "grime":
                case "metal":
                case "country":

                    Console.WriteLine("._.");
                    break;

                case "jazz":
                case "blues":
                case "rap":
                case "pop":

                    Console.WriteLine("I mean fair enough i guess");
                    break;
                default:
                    Console.WriteLine("WHAT");
                    break;
            }
           

            
             
        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="question">The question to ask </param>
        /// <returns>The answer to the question </returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
