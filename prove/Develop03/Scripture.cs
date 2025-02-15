using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Develop03;

public class Scripture{
        private Refrence Refrence = new Refrence(); 
        private Word Word = new Word(); 
        private static List<string> all_words; 
        private string myverse;
        private String mychapter;
        private string mybook;

    public void Getmearef(string Path, out List<string> refrencegotten, out string verse, out string savedchapter, out string savedbook ){

    Refrence.HaveVerseRef(Path, out all_words, out myverse, out mychapter, out mybook);

    refrencegotten = all_words;


    verse = myverse;
    savedchapter = mychapter;
    savedbook = mybook;
    }

public void HideWords(ref List<string> wordref)
{
    for (int i = 0; i < wordref.Count; i++)
    {
        Word.HideORshow(wordref[i], out string wordtext);
        wordref[i] = wordtext; // Modify the original list instead of creating a new one
    }
}
    public void setituptosave(List<string> refrencesaved, string savepath, string verse, string chapter, string book){
            string versesaving = verse.ToString();
            List<string> savingverse = refrencesaved;
            string contentToSave = $"{book} {chapter} {versesaving} {string.Join(" ", savingverse)}";
            Refrence.saveRef(savepath, contentToSave);
    }

    public bool isCompletelyHidden(List<string> scriptureref){
        bool all_hidden = false;
        
        for (int i = 0; i < scriptureref.Count; i++)
        {
            all_hidden = Word.isHidden(scriptureref[i]);
            if (all_hidden == false){
                break;
            }
        }
        return all_hidden;
    }
}