using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var wordsToHide = words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReferenceText());
        Console.WriteLine(string.Join(" ", words.Select(word => word.GetDisplayText())));
    }
}
