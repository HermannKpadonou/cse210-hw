using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            if (unhiddenWords.Count == 0)
            {
                break;
            }
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());

    }

}