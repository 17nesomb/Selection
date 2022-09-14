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
                    Print("Suitable for Vegetarians",ConsoleColor.Green);
                    break;

                case "pepperoni":
                case "meat feast":
                    Print("Contains meat",ConsoleColor.Red);
                    break;

                default:
                    Print("Unknown, May contain meat",ConsoleColor.Red);
                    break;
            }

            string musicGenre = Input("What genre of music is your favourite? ");
            musicGenre.ToLower();

            switch(musicGenre)
            {
                case "rock":
                case "indie":

                    Print("Youre cool, i like you",ConsoleColor.Green);
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
                    Print("WHAT",ConsoleColor.DarkRed);
                    break;
            }
           

            
             
        }

        private static void Print(string output, ConsoleColor textColour)
        {
            
            Console.ForegroundColor = textColour;
            Console.WriteLine(output);
            Console.ResetColor();
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
