using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string gradestring = Console.ReadLine();
        int grade = int.Parse(gradestring);

        string letter = "z";

        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else if (grade < 60){
            letter = "F";
        }

        Console.WriteLine($"your grade is {gradestring} {letter}.");

        if (grade >= 70) {
        Console.WriteLine($"you passed the class");
        }
        else{
        Console.WriteLine($"you failed the class");
        }

    }
}