using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage ");
        String gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        string letter = "";
        string sign = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // add a + || - sign to the grade letter
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F") //This is to determone that there is no A+ OR F+/F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");

        }
        else
        {
            Console.WriteLine("Don't stop, keep pushing harder. You can do better next time.");
        }
    }
}