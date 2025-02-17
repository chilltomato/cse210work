using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Word{

private static readonly Random rand = new Random(); // Shared random instance
private bool is_hidden;
private string word;


    public Word(string text)
    {
        word = text; 
        is_hidden = false;
    }

    public void HideOrShow()
    {
        if (rand.NextDouble() > 0.6) // 40% chance of hiding
        {
            is_hidden = true;
        }
    }

    public bool IsHidden()
    {
        return is_hidden;
    }

    public override string ToString()
    {
        return word;
    }
}