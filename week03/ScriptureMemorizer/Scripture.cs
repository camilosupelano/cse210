using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string [] wordSplit = text.Split(' ');
        foreach (string word in wordSplit )
        {
            _words.Add (new Word(word));
        }
    }
    public void HideRandomWords (int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        List<int> visibleWords = new List<int>();
        for(int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWords.Add(i);
            }
        }

        if (visibleWords.Count == 0)
            return;

        while (wordsHidden < numberToHide && visibleWords.Count > 0)
        {
            int randomIndex = rand.Next(visibleWords.Count);
            int wordIndex = visibleWords [randomIndex];
            
        

            _words[wordIndex].Hide();
            wordsHidden++;

            visibleWords.RemoveAt(randomIndex);
        }

 
    }

  

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    
}
