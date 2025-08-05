using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double US_SHIPPING_COST = 5.00;
    private const double INTERNATIONAL_SHIPPING_COST = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.IsUSA() ? US_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetFullAddress();
        return $"{customerName}\n{customerAddress}";
    }
}