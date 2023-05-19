using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter Number: ");
        string answer = Console.ReadLine();

        int number = int.Parse(answer);

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter Number: ");
            answer = Console.ReadLine();

            number = int.Parse(answer);
        }

        int sum = numbers.Sum(x => Convert.ToInt32(x));
        double average = numbers.Average();

        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average is {Math.Round(average, 2)}");
        Console.WriteLine($"The max number is {numbers.Max()}");
    }
}