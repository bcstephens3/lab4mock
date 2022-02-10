using System;

namespace lab4mock
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuMethod();
        }

        static void MenuMethod()
        {
            double hamTotalMoney = 0.0;
            System.Console.WriteLine("Howdy partner! The name is Sherriff Woody. Use the following integers to select a menu choice:\n1. Andy's Coming!\n2. Give Ham a Coin!\n3. Ham's Money balance!\n4. Exit!");
            string userInput = Console.ReadLine();
            while(userInput != "4")
            {
                if(userInput != "1" && userInput != "2" && userInput != "3")
                {
                    System.Console.WriteLine("That was an invalid menu choice, Space Ranger!");
                }
                if(userInput == "1")
                {
                    bool andyBool = AndyCheck();
                    TheToysDecision(andyBool);
                }
                if(userInput == "2")
                {
                    GiveHamACoin(ref hamTotalMoney);
                }
                if(userInput == "3")
                {
                    CheckHamsBalance(ref hamTotalMoney);
                }
                System.Console.WriteLine("Howdy partner! The name is Sherriff Woody. Use the following integers to select a menu choice:\n1. Andy's Coming!\n2. Give Ham a Coin!\n3. Ham's Money balance!\n4. Exit!");
                userInput = Console.ReadLine();
            }
        }
        static void CheckHamsBalance(ref double hamTotalMoney)
        {
            System.Console.WriteLine("Ham's Money Balance: $" + hamTotalMoney);
        }
        static bool AndyCheck()
        {
            System.Console.WriteLine("Quick! Type our code word 'toy' if Andy is coming!");
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
        static double GiveHamACoin(ref double hamTotalMoney)
        {
            System.Console.WriteLine("Hey you people, it's Ham. To give me a coin, just type what coin you're handing me.");
            System.Console.WriteLine("Your options are penny, nickel, dime, and quarter.");
            string coinChoice = Console.ReadLine();
            if(coinChoice.ToLower() == "penny")
            {
                hamTotalMoney = hamTotalMoney + 0.01;
            }
            if(coinChoice.ToLower() == "nickel")
            {
                hamTotalMoney = hamTotalMoney + 0.05;
            }
            if(coinChoice.ToLower() == "dime")
            {
                hamTotalMoney = hamTotalMoney + 0.10;
            }
            if(coinChoice.ToLower() == "quarter")
            {
                hamTotalMoney = hamTotalMoney + 0.25;
            }
            else
            {
                System.Console.WriteLine("I don't recognize that, I'm just a pig.");
            }
            return hamTotalMoney;
        }
    }
}
