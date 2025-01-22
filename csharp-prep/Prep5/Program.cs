using System;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        
        string username = Promptusername();
        int userNumber = Promptusernumber();

        int squaredNumber = squareNumber(userNumber);

        Displayresult(username, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello world!");
    }
    static string Promptusername()
    {
        Console.Write("What is your user name? ");
        string nameofuser = Console.ReadLine();
        
        return nameofuser;
    }
    static int Promptusernumber()
    {
        int numberuser = 0;

        Console.Write("What is your user number? ");
        numberuser  = int.Parse(Console.ReadLine());
        
        return numberuser;
    }


    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void Displayresult(string name, int square)
    {
        Console.WriteLine($"{name}, {square} is the square of your number .");

    }

}