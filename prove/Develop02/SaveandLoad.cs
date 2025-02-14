using System;
using System.Collections.Generic;
using System.IO;

public class SaveAndLoad
{
    public List<string> LoadFile(string filename)
    {
        if (File.Exists(filename))
        {
            return new List<string>(File.ReadAllLines(filename));
        }
        else
        {
            Console.WriteLine("File not found.");
            return new List<string>();
        }
    }

    public void SaveFile(List<string> journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in journal)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}
