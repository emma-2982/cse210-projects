public class OrderItem
{
    private Product product;
    private int quantity;

    public OrderItem(Product product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }

    public double GetTotal()
    {
        return product.GetPrice() * quantity;
    }

    public string GetItemInfo()
    {
        return $"{product.GetName()} x {quantity} = ${GetTotal():0.00}";
    }
}
