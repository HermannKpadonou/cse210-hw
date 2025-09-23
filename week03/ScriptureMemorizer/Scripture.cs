using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    private DifficultyLevel _currentDifficulty;

    public Scripture(Reference reference, string text, DifficultyLevel difficulty = DifficultyLevel.Medium)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();
        _currentDifficulty = difficulty;

        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords()
    {
        int wordsToHide = GetWordsToHideCount();
        HideRandomWords(wordsToHide);
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

    private int GetWordsToHideCount()
    {
        return _currentDifficulty switch
        {
            DifficultyLevel.Easy => _random.Next(1, 3),    // 1-2 words
            DifficultyLevel.Medium => 3,                   // 3 words (fixed)
            DifficultyLevel.Hard => _random.Next(4, 6),    // 4-5 words
            DifficultyLevel.Expert => _random.Next(6, 9),  // 6-8 words
            _ => 3
        };
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        if (unhiddenWords.Count == 0)
            return;

        // Limit the number of words to hide if necessary
        int actualWordsToHide = Math.Min(numberOfWordsToHide, unhiddenWords.Count);

        for (int i = 0; i < actualWordsToHide; i++)
        {
            if (unhiddenWords.Count == 0)
                break;

            int index = _random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public void SetDifficulty(DifficultyLevel difficulty)
    {
        _currentDifficulty = difficulty;
    }

    public DifficultyLevel GetCurrentDifficulty()
    {
        return _currentDifficulty;
    }

    public string GetDifficultyDescription()
    {
        return _currentDifficulty switch
        {
            DifficultyLevel.Easy => "Easy (1-2 words hidden)",
            DifficultyLevel.Medium => "Medium (3 words hidden)",
            DifficultyLevel.Hard => "Hard (4-5 words hidden)",
            DifficultyLevel.Expert => "Expert (6-8 words hidden)",
            _ => "Medium"
        };
    }
}