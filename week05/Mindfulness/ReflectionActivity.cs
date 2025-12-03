public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you get started?",
        "What did you learn from it?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity helps you reflect on your strengths and resilience.")
    { }

    public void Run()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\n" + _prompts[rnd.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        int time = 0;
        while (time < _duration)
        {
            string q = _questions[rnd.Next(_questions.Count)];
            Console.WriteLine($"> {q}");
            Spinner(4);
            time += 4;
        }

        EndMessage();
    }
}
