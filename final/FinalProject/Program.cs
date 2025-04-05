using System;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character("DefaultName", "DefaultGender", "01 January 2000", "DefaultElement");
        Console.WriteLine("Welcome to the character creator project!");
        Console.WriteLine("This program will help you create a character for your story.");

        while (true)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Create a new character");
            Console.WriteLine("2. edit the character");
            Console.WriteLine("3. save the character");
            Console.WriteLine("4. load the character");
            Console.WriteLine("5. Exit the program");

            string choice = Console.ReadLine();

            if (choice == "1")
            {

                character = Creator.MakeNewCharacter(); // Replace existing character with a new one
                Console.WriteLine("\nCharacter Created!");
            }
            else if (choice == "2")
            {
                Editor.ModifyCharacter(character); // Modify the existing character
            }
            else if (choice == "3")
            {
                    Console.Write("Enter what you want the file to be called: ");
                    string filename = Console.ReadLine() + ".txt";
                    LoadAndSave.Save(character, filename);

            }
            else if (choice == "4")
            {
                    Console.Write("Enter file name to load (include the .txt): ");
                    string filename = Console.ReadLine();
                    Character loadedCharacter = LoadAndSave.Load(filename);
                    if (loadedCharacter != null)
                        character = loadedCharacter;

            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the program. see you later!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}