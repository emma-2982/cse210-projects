using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project");
            List<Activity> activities = new List<Activity>();

            
            Running run = new Running("03 Nov 2022", 30, 3.0); // miles
            Cycling bike = new Cycling("03 Nov 2022", 30, 10.0); // mph
            Swimming swim = new Swimming("03 Nov 2022", 30, 20); // laps

            
            activities.Add(run);
            activities.Add(bike);
            activities.Add(swim);

            // Loop and display
            foreach (Activity act in activities)
            {
                Console.WriteLine(act.GetSummary());
            }
        }
    }


