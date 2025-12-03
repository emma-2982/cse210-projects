public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list positive things in your life.")
    { }

    public void Run()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\n" + _prompts[rnd.Next(_prompts.Count)]);

        Console.WriteLine("Get ready to list items...");
        Spinner(3);

        List<string> items = new List<string>();
        int time = 0;
        while (time < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
            time += 2;
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}
