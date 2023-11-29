using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "buy")
            {
                break;
            }

            string[] productInfo = input.Split();
            string productName = productInfo[0];
            double productPrice = double.Parse(productInfo[1]);
            int productQuantity = int.Parse(productInfo[2]);

            if (products.ContainsKey(productName))
            {
                // Product already exists, update quantity and price if necessary
                products[productName].Quantity += productQuantity;
                if (products[productName].Price != productPrice)
                {
                    products[productName].Price = productPrice;
                }
            }
            else
            {
                // Product doesn't exist, add it with the given quantity
                products[productName] = new Product(productPrice, productQuantity);
            }
        }

        Console.WriteLine();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key} -> {product.Value.GetTotalPrice():F2}");
        }
    }
}

class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
}
