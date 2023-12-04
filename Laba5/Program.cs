using System;
using System.Collections.Generic;
interface ISearchable
{
    List<Product> SearchByPrice(double maxPrice);
    List<Product> SearchByCategory(string category);
    List<Product> SearchByRating(int minRating);
}

// Клас Товар
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Rating { get; set; }
}
class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Order> PurchaseHistory { get; set; } = new List<Order>();
}
class Order
{
    public List<Product> Products { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }
}

// Клас Магазин
class Store : ISearchable
{
    public List<Product> Products { get; set; } = new List<Product>();
    public List<User> Users { get; set; } = new List<User>();
    public List<Order> Orders { get; set; } = new List<Order>();

    public List<Product> SearchByPrice(double maxPrice)
    {
        return Products.FindAll(product => product.Price <= maxPrice);
    }

    public List<Product> SearchByCategory(string category)
    {
        return Products.FindAll(product => product.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
    }

    public List<Product> SearchByRating(int minRating)
    {
        return Products.FindAll(product => product.Rating >= minRating);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Програма завершила роботу.");
    }
}
