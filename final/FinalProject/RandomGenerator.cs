using System;

class RandomGenerator
{

    int AmountRandom;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
    }

    static void Randomize()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100); // Generates a random number between 1 and 100
        Console.WriteLine("Random Number: " + randomNumber);

    }

}