public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    public string Name => name;
    public string ProductId => productId;
    public decimal Price => price;
    public int Quantity => quantity;
    public decimal TotalCost()
    {
        return price * quantity;
    }
    public override string ToString()
    {
        return $"{name} (ID: {productId})";
    }
}