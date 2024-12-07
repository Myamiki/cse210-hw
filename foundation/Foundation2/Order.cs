using System.Collections.Generic;
/* This class stores a list of products and a customer,
it calculates the total price, makes packing labels and
shipping labels*/
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }

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
        double total = 0;
        foreach (var product in _products)
        {
            total += product.CalculateTotalCost();
        }
        total += _customer.IsInUSA() ? 5.00 : 35.00; // Shipping cost
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}
