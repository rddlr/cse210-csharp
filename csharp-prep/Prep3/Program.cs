using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            
            Console.WriteLine($"Let's Play the Magic Number! {number}");
            Console.Write("What is your Guess? ");
            string strNumber = Console.ReadLine();

            int intNumber = int.Parse(strNumber);

            while (intNumber != number)
            {
                if (intNumber > number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your Guess? ");
                    strNumber = Console.ReadLine();
                    intNumber = int.Parse(strNumber);
                }
                else
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your Guess? ");
                    strNumber = Console.ReadLine();
                    intNumber = int.Parse(strNumber);
                }
            }

            Console.WriteLine($"Congratulations! You Got the number {number}!");
            Console.Write("Wanna play again? (Yes or No) ");
            response = Console.ReadLine();
        }
    }
}