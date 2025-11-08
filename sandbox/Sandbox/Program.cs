using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Hello World! This is the Sandbox Project.");
            
            int a = 2;
            int b = 3;
            int Total = AddNumbers(a, b);
            Console.WriteLine($"Total: {Total}");
        }
        
        static int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
    
    }

    


} 