
using System.Numerics;

public class Product
{
    private double _pricePerUnit;
    private string _name;
    private int _productId;
    private int _quantity;

    public Product(double price, string name, int ID, int quantity)
    {
        _pricePerUnit = price;
        _name = name;
        _productId = ID;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _productId;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}