using static System.Collections.Specialized.BitVector32;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Excersise #1----------------------------

            //Note to self for Random Number Generation:
            //"Random r = new Random();
            //int favNumb = r.Next(1, 1000);"

            int favNumber = 77;

            Console.WriteLine("Guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }

            else
            {
                Console.WriteLine("Hooray, you're psychic!!");
            }

            FavoriteSubject();

        }

        //Exercise #2--------------------------------------

        public static void FavoriteSubject()
            {
                Console.WriteLine("What's your favorite school subject?");
                string favoriteSubject = Console.ReadLine();

                switch (favoriteSubject)
                {
                    case "Science":
                        Console.WriteLine("I love nature so, Science!");
                        break;

                    case "Literature":
                        Console.WriteLine("I want to be an actor so Lit is my fave");
                        break;

                    case "Math":
                        Console.WriteLine("Don't judge me, but it's Math");
                        break;
                }

            }


            
       
    }
}
