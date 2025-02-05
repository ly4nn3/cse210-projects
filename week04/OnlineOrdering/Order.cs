using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _totalPrice;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float CalculateTotalPrice()
    {
        float productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.ComputeTotalPrice();
        }
        float shippingCost = _customer.HasDomesticShipping() ? 5 : 35;
        _totalPrice = productTotal + shippingCost;
        return _totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label += $"Product: {product.GetProductName()}, ID: {product.GetProductId()}, Quantity: {product.GetOrderQuantity()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetFullAddress()}";
    }
}