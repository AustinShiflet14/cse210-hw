public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        //depending on if cust is in usa 
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string result = "____________________________\n\nPacking Label:\n";
        foreach (Product product in _products)
        {
            result += product.GetPackingInfo() + "\n";
        }
        return result;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingInfo();
    }
}