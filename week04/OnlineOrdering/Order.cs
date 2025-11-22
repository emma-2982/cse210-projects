using System;
using System.Collections.Generic;

public class Order
{
    private string customerName;
    private List<OrderItem> orderItems;

    public Order(string customerName)
    {
        this.customerName = customerName;
        orderItems = new List<OrderItem>();
    }

    public void AddItem(Product product, int quantity)
    {
        orderItems.Add(new OrderItem(product, quantity));
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in orderItems)
            total += item.GetTotal();
        return total;
    }

    public void PrintReceipt()
    {
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine("Order Details:");
        foreach (var item in orderItems)
            Console.WriteLine(item.GetItemInfo());
        Console.WriteLine($"Total: ${CalculateTotal():0.00}");
    }
}
