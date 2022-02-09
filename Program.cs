using System;

namespace lab4bstorm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool andyBool = AndyCheck();
            TheToysDecision(andyBool);
        }
        static bool AndyCheck()
        {
            System.Console.WriteLine("It's woody and buzz lightyear! Type our code word 'toy' if Andy is coming!");
            System.Console.WriteLine("If he isn't, type any other word you'd like!");
            string userInput = Console.ReadLine();
            if(userInput == "toy"|| userInput == "Toy")
            {
                return true;
            }
            else //if(userInput == "no"|| userInput == "No")
            {
                return false;
            }
        }
        static void TheToysDecision(bool andyBool)
        {
            if(andyBool == true)
            {
                System.Console.WriteLine("Guys, Andy's coming!!!");
            }
            if(andyBool == false)
            {
                int woodysNumber = GetRandomNumber();
                System.Console.WriteLine("That was close! That makes " + woodysNumber + " close calls this week!");
            }
        }
        static int GetRandomNumber()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,100);

            return number;
        }
    }
}
