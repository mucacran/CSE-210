using System;

class Entry
{
    public string Prompt { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }

    //public Entry(string prompt, string text)
    public Entry(){
        
    }
    public Entry(string prompt, string text)
    {
        Prompt = prompt;
        Text = text;
        Date = DateTime.Now; // Se asigna la fecha actual
    }

    public string GetDetails()
    {
        return $"Date: {Date.ToShortDateString()} - Prompt: {Prompt}\n{Text}";
    }
}
