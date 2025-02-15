using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Word{

private bool is_hidden;



    public string HideORshow(string Word, out string wordText){
        Random rand = new Random();
        is_hidden = rand.NextDouble() > 0.9; // 10% chance of hiding the word
        wordText = is_hidden ? "_" : Word;
        return wordText;}
    public bool isHidden(string word){
        if (word=="_"){
            is_hidden = true;
        }
        else{
            is_hidden = false;
        }
        return is_hidden;
    }

}