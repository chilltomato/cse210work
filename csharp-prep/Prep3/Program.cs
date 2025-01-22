using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);

        int magicNumberGuess = -1;

        int guesses = 1;
    while (magicnumber != magicNumberGuess )
    {
        Console.Write("What is your guess? ");
         magicNumberGuess  = int.Parse(Console.ReadLine());

        if (magicnumber > magicNumberGuess ){
            Console.WriteLine("higher!");
            guesses = guesses + 1;
        }
        else if (magicnumber < magicNumberGuess ){
            Console.WriteLine("lower!");
            guesses = guesses + 1;
    
    };
    
    }
    Console.Write($"You guessed it! only took you {guesses} guesses");


    }
}