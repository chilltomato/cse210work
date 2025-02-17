using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.IO;


namespace Develop03
{
    public class Refrence
    {
    private string book;
    private string chapter;
    private List<string> otherverseWords;


        public Refrence()
        {
            book = "";
            chapter = "";
            otherverseWords = new List<string>();
}

public void HaveVerseRef(string versefilelocation, out List<string> verseWords, out string verseOut, out string chapterOut, out string bookOut)
{
    verseWords = new List<string>(); 
    verseOut = "";
    chapterOut = "";
    bookOut = "";

    string[] lines = File.ReadAllLines(versefilelocation);

    foreach (string line in lines)
    {

        string[] parts = line.Split(' '); // Splitting by spaces

        if (parts.Length >= 4) // Ensure we have at least book, chapter, verse, and some words
        {
            bookOut = parts[0]; // Book is from the first part
            book = bookOut; // Assign to the field 'book'
            chapterOut = parts[1]; // Chapter as string
            verseOut = parts[2]; // Verse as string
            chapter = chapterOut; // Assign to the field 'chapter'

            List<string> otherverseWords = parts.Skip(3).ToList(); // The remaining words are the verse text
            verseWords.AddRange(otherverseWords); // Add the words to the list
        }
        else
        {
            Console.WriteLine($"WARNING: Skipping malformed line -> {line}");
        }
    }
}
        public void saveRef(string wheretosaveit, string refrencesaved)
        {
            File.WriteAllText(wheretosaveit, refrencesaved);
        }
}
}