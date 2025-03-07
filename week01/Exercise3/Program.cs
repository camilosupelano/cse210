using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess this magic number: ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
        if (guess < magicNumber)
        {
            Console.WriteLine("higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        }
            
    }
}