using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";
        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attemps = 0;

            while (guess != magicNumber)
            {
                attemps++;

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Congrats you guessed it!!");
                }
            }
            Console.WriteLine($"Total attemps {attemps}");
            Console.Write("Do you want to continue? ");
            answer = Console.ReadLine();
        }

    }
}