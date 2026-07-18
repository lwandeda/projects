using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText();
        display += "\n";

        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display;
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}