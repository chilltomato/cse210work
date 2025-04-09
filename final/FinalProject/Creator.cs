using System;
using System.Collections.Generic;

class Creator
{
    public Creator()
    {
    }
    
    public static Character MakeNewCharacter()
    {
        string characterName;
        string characterElement;
        List<string> characterQuotes = new List<string>();
        var nameGen = new RandomNameGenerator();
        var quoteGen = new RandomQuoteGenerator();
        var elemGen = new RandomElementGenerator();
        var BirthGen = new RandomBirthdayGenerator();

        Console.Write("do you want to pick a random name? y/n ");
        string randomName = Console.ReadLine().ToLower();

        if (randomName == "y")
        {
            characterName = nameGen.Randomize();
            Console.WriteLine($" ok, here you go, it's {characterName}");
        }
        else
        {
            Console.Write("What is your character's name? ");
            characterName = Console.ReadLine();
        }

        Console.Write("What is your character's gender? ");
        string characterGender = Console.ReadLine();

        Console.Write("do you want to pick a random Birthday? y/n ");
        string randomBirthday = Console.ReadLine().ToLower();
        string birthdayStr;
        if (randomBirthday == "y")
        {
            birthdayStr = BirthGen.Randomize();
            Console.WriteLine($" ok, here you go, it's {birthdayStr}");
        }
        else
        {
            Console.Write("What is your character's birthday (format: dd/MM/yyyy)? ");
            birthdayStr = Console.ReadLine();
        }
        DateTime characterBirthday = DateTime.ParseExact(birthdayStr, "dd/MM/yyyy", null);
        Console.Write("do you want to pick a random Element? y/n ");
        string randomElement = Console.ReadLine().ToLower();

        if (randomElement == "y")
        {
            characterElement = elemGen.Randomize();
            Console.WriteLine($" ok, here you go, it's {characterElement}");
        }
        else
        {
            Console.Write("What is your character's element? ");
            characterElement = Console.ReadLine();
        }


        string more = "y";
        while (more == "y")
        {
            Console.Write("Do you want to have a random quote? y/n ");
            string randomQuote = Console.ReadLine().ToLower();
            string quote;

            if (randomQuote == "y")
            {
                quote = quoteGen.Randomize();
                Console.WriteLine($"Ok, here you go, it's \"{quote}\"");
            }
            else
            {
                quote = Console.ReadLine();
            }

            characterQuotes.Add(quote);

            Console.Write("Do you want to add another quote? (y/n) ");
            more = Console.ReadLine().ToLower();
        }

        return new Character(characterName, characterGender, characterBirthday.ToString("dd/MM/yyyy"), characterElement);
    }
}
