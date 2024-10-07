using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.GetDetails() + "\n");
        }
    }

    public void SaveEntries(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string prompt = entry.Prompt;
                string text = entry.Text;
                string date = entry.Date.ToShortDateString();

                //writer.WriteLine(entry.GetDetails());
                writer.WriteLine($"{date}~~{prompt}~~{text}");
            }
        }
    }

    public void LoadEntries(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //string textLine = reader.ReadLine(); // Asume que la siguiente línea es el texto de la entrada
                //string[] dateParts = line.Split('-'); // Divide la línea para obtener la fecha
                //string date = dateParts[0].Trim(); // Limpia los espacios


                //Entry newEntry = new Entry("textLine", line);
                string[] part = line.Split("~~");
                Entry newEntry = new Entry();

                newEntry.Date = DateTime.Parse(part[0]);
                newEntry.Prompt = part[1];
                newEntry.Text = part[2];

                entries.Add(newEntry);
            }
        }
    }

    public void RemoveEntry(int index)
    {
        if (index >= 0 && index < entries.Count)
        {
            entries.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Índice no válido.");
        }
    }
}
