using System;

class Creator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FinalProject!");
        Character myCharacter = MakeNewCharacter(); // Create character instance

        Console.WriteLine("\nCharacter successfully created!");
        myCharacter.DisplayCharacterInfo(); // Show character info
    }

    static Character MakeNewCharacter()
    {
        Console.Write("What is your character's name? ");
        string characterName = Console.ReadLine();

        Console.Write("What is your character's gender? ");
        string characterGender = Console.ReadLine();

        Console.Write("What is your character's birthday (format: dd/MM/yyyy)? ");
        string characterBirthday = Console.ReadLine();

        Console.Write("What is your character's element? ");
        string characterElement = Console.ReadLine();

        // Create and return the Character object
        return new Character(characterName, characterGender, characterBirthday, characterElement);
    }
}
