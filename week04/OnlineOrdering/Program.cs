using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        {
            Product milk = new Product(1, "Milk", 2.50);
            Product phone = new Product(2, "Phone", 499.99);
            Product tshirt = new Product(3, "T-shirt", 15.00);

            Order order = new Order("John Doe");
            order.AddItem(milk, 2);
            order.AddItem(phone, 1);
            order.AddItem(tshirt, 3);

            order.PrintReceipt();
        }
    }

}
