public class Order{
    private List<Product> products;
    private Customer customer;
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address}";
    }
}