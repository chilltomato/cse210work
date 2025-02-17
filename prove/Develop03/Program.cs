using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;


class Program
{

    static void Main(string[] args)
    {   
        string path =  Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt"); // default path for testing
        Scripture scripture = new Scripture(); 

        Console.WriteLine("this helps you with scripture memorization");
        Thread.Sleep(200);
        Console.WriteLine("you set up the files in this format (all one line recomended):");
        Thread.Sleep(200);
        Console.WriteLine("book chapter verse(s) words");
        Thread.Sleep(200);
        Console.WriteLine("example: John 3 16 For God so loved the world");
        Console.WriteLine("and you save them in the \\bin\\Debug\\net8.0 foulder");
        Thread.Sleep(200);
        Console.WriteLine($"example path {path}");
        Thread.Sleep(200);
        Console.WriteLine("and remember, type quit to exit the program early");
        Thread.Sleep(200);
        Console.WriteLine("so, what file would you like to study?");
        path = Console.ReadLine();
        Console.Clear();
        if (File.Exists(path)) // Ensure the file exists
        {
            List<String> scriptureref;            
            string inputtext="";
            string verse;
            bool all_hidden = false;
            string savedchapter;
            string savedbook;   
            scripture.Getmearef(path, out scriptureref, out verse, out savedchapter, out savedbook);

            while (inputtext !="quit" && !all_hidden){
                if (inputtext != "quit" && !all_hidden)
                {
                scripture.DisplayVerse();
                inputtext = Console.ReadLine();

                scripture.HideWords();
                all_hidden = scripture.isCompletelyHidden(); // Now correctly updates
                Console.Clear();
                }
                else
                {
                    break;
                }
                }

                if (all_hidden == true)
                {
                    Console.WriteLine("you studied really well, you memorized the verse!");
                    Console.WriteLine("tell your friends, they will be impressed.");
                    Console.WriteLine("at least I think so.");
                }
                scripture.setituptosave(scriptureref, path, verse, savedchapter, savedbook);
            }
            else
            {
                Console.WriteLine("That file doesn't exist, try again sir. also, I hope you didn't do that on purpose.");
            }
        }
        }
    

    

