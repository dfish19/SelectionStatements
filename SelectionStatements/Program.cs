using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Correctly And you Win!");

            var r = new Random();
            var number = r.Next(1,7);

            Console.WriteLine("Input A Number");
            var guess = int.Parse(Console.ReadLine());

            if(guess > 6)
            {
                Console.WriteLine("Excellent!");
            }
            else if(guess != number)
            {
                Console.WriteLine("Wrong!");
                Console.WriteLine();
            }
            Console.WriteLine("What is your favorite subject?");
            string  subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine();
                    Console.WriteLine("Much Needed subject");
                    break;

                case "Science":
                    Console.WriteLine();
                    Console.WriteLine("My favorite subject");
                    break;

                case "Lunch":
                    Console.WriteLine();
                    Console.WriteLine("Best time of day");
                    break;

                case "Gym":
                    Console.WriteLine();
                    Console.WriteLine("Everyone passes");
                    break;

                case "Detention":
                    Console.WriteLine();
                    Console.WriteLine("Not popular");
                    break;

                    default: Console.WriteLine("Not Valid");
                    break ;
            }
        }
    }
}