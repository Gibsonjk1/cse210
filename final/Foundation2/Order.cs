public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int _USShipping = 5;
    private int _internationalShipping = 35;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateCost()
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            cost += product.TotalCost();
        }
        if (_customer.IsUSCustomer() == true)
        {
            cost += _USShipping;
        }
        else
        {
            cost += _internationalShipping;
        }
        return cost;
    }

    public string ShippingLabel()
    {
        string shipping = "";
        shipping += $"{_customer.GetName()}, \n";
        shipping += _customer.GetAddress();
        return shipping;
    }

    public List<string> PackingLabel()
    {
        List<string> packingList = new List<string>();
        foreach (Product product in _products)
        {
            string packing = $"{product.GetName()}, {product.GetID()}";
            packingList.Add(packing);
        }
        return packingList;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}