using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToShortDateString();

string prompt = "";
string name = "";
List<string> journal = new List<string>();
string nextentry = "";
string nextentrywithmore = "";
int option = 0;
Promptgenerator promptGenerator = new Promptgenerator();
SaveAndLoad fileManager = new SaveAndLoad();

while (option != 5 ){
Console.WriteLine("please select from the following choices: ");
Console.WriteLine("1. Write");
Console.WriteLine("2. Display");
Console.WriteLine("3. Load");
Console.WriteLine("4. Save");
Console.WriteLine("5. Quit");
Console.WriteLine("What would you like to do? ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                continue;
            }

        if (option == 1)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("By the way, what's my name? ");
                name = Console.ReadLine();
                journal.Add(name);  // Add the name only once at the start
            }
            
                prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                nextentry = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(nextentry))
                {
                    nextentrywithmore = $"{dateText}, {prompt}, {nextentry}";
                    journal.Add(nextentrywithmore); // Add journal entry
                }
        }
        else if (option == 2)
        {
            foreach (string entry in journal)
            {
                Console.WriteLine(entry);
            }
        }
    else if (option == 3)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine()?.Trim();
        List<string> loadedJournal = fileManager.LoadFile(filename);
        
        if (loadedJournal.Count > 0)
        {
            journal = loadedJournal;
            name = journal[0]; // Update name if file contains entries
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("Failed to load journal or file is empty.");
        }
    }
            else if (option == 4)
            {
                Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine()?.Trim();
                fileManager.SaveFile(journal, filename);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (option == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
};