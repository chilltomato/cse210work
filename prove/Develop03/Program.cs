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
            List<String> scriptureref = new List<string>();            
            string inputtext="continue";
            string verse = "1.3";
            bool all_hidden = false;
            string savedchapter = "0";
            string savedbook = string.Empty;            
            scripture.Getmearef(path, out scriptureref, out verse, out savedchapter, out savedbook);

            while (inputtext !="quit" && all_hidden == false){
                if (inputtext != "quit" && all_hidden == false)
                {
                    all_hidden = scripture.isCompletelyHidden(scriptureref);
                    Console.WriteLine($"\n{savedbook} {savedchapter}:{verse}");
                    for (int i = 0; i < scriptureref.Count; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write($"{scriptureref[i]} ");
                    }
                    Console.WriteLine("");
                    inputtext = Console.ReadLine();
                    scripture.HideWords(ref scriptureref);
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
    

    

