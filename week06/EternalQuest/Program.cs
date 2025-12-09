using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        {
            List<Goal> goals = new List<Goal>();
            int score = 0;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("=== Eternal Quest ===");
                Console.WriteLine($"Current Score: {score}");
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal(goals);
                        break;

                    case "2":
                        ListGoals(goals);
                        break;

                    case "3":
                        SaveGoals(goals, score);
                        break;

                    case "4":
                        score = LoadGoals(goals);
                        break;

                    case "5":
                        score += RecordEvent(goals);
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1–6.");
                        break;
                }
            }

            Console.WriteLine("Goodbye! Keep working on your Eternal Quest!");
        }

        static void CreateGoal(List<Goal> goals)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string typeChoice = Console.ReadLine();

            Console.Write("What is the short name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch (typeChoice)
            {
                case "1": // Simple
                    goals.Add(new SimpleGoal(name, description, points));
                    break;

                case "2": // Eternal
                    goals.Add(new EternalGoal(name, description, points));
                    break;

                case "3": // Checklist
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, description, points, target, 0, bonus));
                    break;

                default:
                    Console.WriteLine("Invalid goal type. Goal not created.");
                    break;
            }
        }

        static void ListGoals(List<Goal> goals)
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            Console.WriteLine("Your goals:");
            int index = 1;
            foreach (Goal goal in goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }

        static void SaveGoals(List<Goal> goals, int score)
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // First line: score
                outputFile.WriteLine(score);

                // Next lines: one line per goal
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }

        static int LoadGoals(List<Goal> goals)
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return 0;
            }

            string[] lines = File.ReadAllLines(filename);

            goals.Clear(); // remove old goals

            // First line is score
            int newScore = int.Parse(lines[0]);

            // Next lines are goals
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

    

                string[] parts = line.Split(':');
                string type = parts[0];
                string data = parts[1];

                string[] values = data.Split('|');

                if (type == "SimpleGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    int points = int.Parse(values[2]);
                    bool isComplete = bool.Parse(values[3]);

                    goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (type == "EternalGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    int points = int.Parse(values[2]);

                    goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    string name = values[0];
                    string description = values[1];
                    int points = int.Parse(values[2]);
                    int target = int.Parse(values[3]);
                    int current = int.Parse(values[4]);
                    int bonus = int.Parse(values[5]);

                    goals.Add(new ChecklistGoal(name, description, points, target, current, bonus));
                }
            }

            Console.WriteLine("Goals loaded successfully.");
            return newScore;
        }

        static int RecordEvent(List<Goal> goals)
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals to record. Create a goal first.");
                return 0;
            }

            Console.WriteLine("Which goal did you accomplish?");
            int index = 1;
            foreach (Goal goal in goals)
            {
                Console.WriteLine($"{index}. {goal.ShortName}");
                index++;
            }

            Console.Write("Enter the number: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return 0;
            }

            Goal selectedGoal = goals[choice - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            Console.WriteLine($"You now earned {pointsEarned} points from this event.");

            return pointsEarned;
        }
    }

}

