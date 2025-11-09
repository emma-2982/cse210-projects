using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        
        Journal journal = new Journal();

            List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine();
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    
                    Random random = new Random();
                    int index = random.Next(prompts.Count);
                    string prompt = prompts[index];

                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._prompt = prompt;
                    newEntry._response = response;

                    journal.AddEntry(newEntry);
                }
                else if (choice == 2)
                {
                    journal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter filename to save: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully!");
                }
                else if (choice == 4)
                {
                    Console.Write("Enter filename to load: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
        }
    }
}
