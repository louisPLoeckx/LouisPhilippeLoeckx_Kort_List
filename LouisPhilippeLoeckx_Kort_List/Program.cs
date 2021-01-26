using LouisPhilippeLoeckx_Kort_List.Models;
using System.Collections.Generic;

namespace LouisPhilippeLoeckx_Kort_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product Cola = new Product()
            {
                Merk = "Cola",
                Naam = "Zero",
                Volume = "150 ml"
            };
            Product Fanta = new Product()
            {
                Merk = "Fanta",
                Naam = "Lemon",
                Volume = "1000 ml"
            }; 
            Product Soda = new Product()
            {
                Merk = "Soda",
                Naam = "Gas",
                Volume = "150 ml"
            };

            products.Add(Cola);
            products.Add(Fanta);
            products.Add(Soda);

            foreach (var product in products)
            {
                System.Console.WriteLine(product.GetCode());
            }
        }
    }
}
