using System;
public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse; // Para escrituras con múltiples versículos

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetReferenceText()
    {
        if (endVerse == null)
            return $"{book} {chapter}:{startVerse}";
        else
            return $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}
