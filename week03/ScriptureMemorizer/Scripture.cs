using System;

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

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int attempts = 0;

        while (numberToHide > 0 && attempts < 100)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                numberToHide--;
            }
            attempts++;
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordsText}";
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