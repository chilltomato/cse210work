using System;
using System.Collections.Generic;
using System.IO;

class LoadAndSave
{
    public static void Save(Character character, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Name: {character.Name}");
            writer.WriteLine($"Gender: {character.Gender}");
            writer.WriteLine($"Birthday: {character.Birthday:yyyy-MM-dd}");
            writer.WriteLine($"Element: {character.Element}");
            writer.WriteLine("Quotes:");
            foreach (string quote in character.Quotes)
            {
                writer.WriteLine($"- {quote}");
                Console.WriteLine("Saving quote: " + quote);
            }
        }

        Console.WriteLine("Character saved successfully.");
    }

    public static Character Load(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return null;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            string name = reader.ReadLine()?.Replace("Name: ", "").Trim();
            string gender = reader.ReadLine()?.Replace("Gender: ", "").Trim();
            string birthdayStr = reader.ReadLine()?.Replace("Birthday: ", "").Trim();
            DateTime birthday = DateTime.ParseExact(birthdayStr, "yyyy-MM-dd", null);
            string element = reader.ReadLine()?.Replace("Element: ", "").Trim();

            Character character = new Character(name, gender, birthday.ToString("yyyy-MM-dd"), element);

            string quotesHeader = reader.ReadLine(); // "Quotes:"
            if (quotesHeader != null && quotesHeader.StartsWith("Quotes"))
            {
                while (!reader.EndOfStream)
                {
                    string quoteLine = reader.ReadLine()?.Trim();
                    if (!string.IsNullOrWhiteSpace(quoteLine) && quoteLine.StartsWith("- "))
                    {
                        character.Quotes.Add(quoteLine.Substring(2)); 
                    }
                }
            }

            Console.WriteLine("Character loaded successfully.");
            return character;
        }
    }
}
