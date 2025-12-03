public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int time = 0;
        while (time < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            Spinner(4);
            time += 4;

            if (time >= _duration) break;

            Console.WriteLine("Breathe out...");
            Spinner(4);
            time += 4;
        }

        EndMessage();
    }
}
