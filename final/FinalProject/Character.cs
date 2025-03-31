using System;
using System.Collections.Generic;

class Character
{
    public string Name { get; private set; }
    public string Gender { get; private set; }
    public int Age { get; private set; }
    public string Birthday { get; private set; }
    public string Element { get; private set; }
    public List<string> Quotes { get; private set; }

    // Constructor to initialize character
    public Character(string name, string gender, string birthday, string element)
    {
        Name = name;
        Gender = gender;
        Birthday = birthday;
        Element = element;
        Age = CalculateAge(birthday);
        Quotes = new List<string>(); // Initialize empty quotes list
    }

    // Method to calculate age from birthday
    private int CalculateAge(string birthday)
    {
        try
        {
            DateTime birthDate = DateTime.ParseExact(birthday, "dd/MM/yyyy", null);
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now < birthDate.AddYears(age)) 
                age--; // Adjust age if birthday hasn't happened yet this year

            return age;
        }
        catch
        {
            Console.WriteLine("Invalid birthday format. Age set to 0.");
            return 0;
        }
    }

    // Method to display character details
    public void DisplayCharacterInfo()
    {
        Console.WriteLine($"\nCharacter Info:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Birthday: {Birthday}");
        Console.WriteLine($"Element: {Element}");
    }
}
