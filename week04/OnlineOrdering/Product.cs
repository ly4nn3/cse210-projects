public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float ComputeTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _id;
    }

    public float GetUnitPrice()
    {
        return _price;
    }

    public int GetOrderQuantity()
    {
        return _quantity;
    }
}