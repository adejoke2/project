using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1,50);

            int trial = 3;

            Console.WriteLine("I am thinking of a number between 1-50.  Can you guess what it is?");

           while (Guess != returnValue)
           {
            Guess = Convert.ToInt32(Console.ReadLine());

            if (Guess < returnValue)
            {
                Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess again?");
            }
            else if (Guess > returnValue)
            {
                Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess for the third time?");
            }
           else
           {
               
            Console.WriteLine("Yeahh! The answer was " + returnValue)
            Console.ReadLine();
            break;

           }
        }


      }
     
    }   
}  
             


