using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    // Displays this entry’s information
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }
}
