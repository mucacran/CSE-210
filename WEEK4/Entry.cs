using System;

class Entry
{
    public string _Prompt { get; set; }
    public string _Text { get; set; }
    public DateTime _Date { get; set; }

    public Entry(){

    }
    public Entry(string prompt, string text)
    {
        _Prompt = prompt;
        _Text = text;
        _Date = DateTime.Now; // Se asigna la fecha actual
    }

    public string GetDetails()
    {
        return $"Date: {_Date.ToShortDateString()} - Prompt: {_Prompt}\n{_Text}";
    }
}
