using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int nextnumber = 1;
     
        int listlength = 0;

        while (nextnumber !=0){
         Console.Write("Enter number (type 0 when finished): ");
         
         nextnumber  = int.Parse(Console.ReadLine());
         if (nextnumber != 0){
            numbers.Add(nextnumber);
            listlength += 1;
         }
        } 
        
        int sum = 0;

        foreach (int number in numbers)
        {
           sum += number;
        }

        Console.WriteLine($"the sum is {sum}.");

        float average = ((float)sum) / listlength;
        Console.WriteLine($"the average is {average}.");


        int largestnumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestnumber){
                largestnumber = number;
            } 
        }

        Console.WriteLine($"{largestnumber} is the largest number on the list.");

        }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
