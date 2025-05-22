using System;

public class Program
{
    public static Journal _journal = new Journal();
    public static PromptGenerator _promptGenerator = new PromptGenerator();

    public static void Main()
    {
        bool _running = true;
        while (_running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Display journal");
            Console.WriteLine("3 - Save journal");
            Console.WriteLine("4 - Load journal");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose an option: ");
            string _choice = Console.ReadLine();

            switch (_choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    _journal.DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    _running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    public static void WriteEntry()
    {
        string _prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\n{_prompt}");
        Console.Write("Your response: ");
        string _response = Console.ReadLine();
        _journal.AddEntry(_prompt, _response);
    }

    public static void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string _filename = Console.ReadLine();
        _journal.SaveToFile(_filename);
    }

    public static void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string _filename = Console.ReadLine();
        _journal.LoadFromFile(_filename);
    }
}
