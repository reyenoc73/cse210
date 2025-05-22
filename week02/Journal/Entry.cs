using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }
}
