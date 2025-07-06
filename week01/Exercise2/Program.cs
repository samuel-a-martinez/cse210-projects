using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";


        Console.Write("What's your grade? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        int sign = grade % 10;
        string character = "";

        if (sign >= 7)
        {
            character = "+";
        }
        else if (sign < 3)
        {
            character = "-";
        }
        else
        {
            character = "";
        }

        if (grade >= 94)
        {
            character = "";
        }
        else if (grade <= 59)
        {
            character = "";
        }

        Console.WriteLine($"Your score is {character}{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you pass the class!!");
        }
        else
        {
            Console.WriteLine("I'm sorry you don't pass the class");
        }

    }
}