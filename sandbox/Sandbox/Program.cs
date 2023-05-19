using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response.ToLower() == "yes")
        {
            Console.Write("Write your grade percentage: ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);

            string letter = "";

            if (percent >= 90)
            {
                letter = "A";
            }
            else if (percent >= 80)
            {
                letter = "B";
            }
            else if (percent >= 70)
            {
                letter = "C";
            }
            else if (percent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
            
            Console.WriteLine("Do you want to try again? ");
            response = Console.ReadLine();
        }
    }
}