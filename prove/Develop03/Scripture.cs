using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Develop03;

public class Scripture{
        private Refrence Refrence = new Refrence(); 
        private readonly Word Word = new("defaultText"); 
        private static List<Word> all_words; 
        private static List<string> allWordstrings; // Store Word objects instead of strings
        private string myverse;
        private String mychapter;
        private string mybook;

    public void Getmearef(string Path, out List<string> refrencegotten, out string verse, out string savedchapter, out string savedbook ){

    Refrence.HaveVerseRef(Path, out allWordstrings, out myverse, out mychapter, out mybook);

        refrencegotten = allWordstrings; // Convert Word objects back to strings
        
        all_words = allWordstrings.Select(word => new Word(word)).ToList();



    verse = myverse;
    savedchapter = mychapter;
    savedbook = mybook;
    }

    public void HideWords()
    {
        foreach (var word in all_words) {
            word.HideOrShow(); 
        }
    }
    public void setituptosave(List<string> refrencesaved, string savepath, string verse, string chapter, string book){
            string versesaving = verse.ToString();
            List<string> savingverse = refrencesaved;
            string contentToSave = $"{book} {chapter} {versesaving} {string.Join(" ", savingverse)}";
            Refrence.saveRef(savepath, contentToSave);
    }

    public bool isCompletelyHidden()
    {
        return all_words.All(word => word.IsHidden());
    }

    public void DisplayVerse()
    {
        Console.WriteLine($"\n{mybook} {mychapter}:{myverse}");
        foreach (var word in all_words)
        {
            bool isHidden = word.IsHidden();
            if (isHidden)
            {
                Random rand = new Random();
                if (rand.NextDouble() > 0.5) // 50% chance of hiding
                {
                Console.Write($"{word} ");
                Thread.Sleep(200); 
                int cursorLeft = Console.CursorLeft;
                Console.SetCursorPosition(cursorLeft - 1, Console.CursorTop);
                Console.Write(" _ ");
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
            else
            {
                Console.Write($"{word} ");
            }
            Thread.Sleep(200); 
        }
        Console.WriteLine(); // New line after printing all words
    }
}
