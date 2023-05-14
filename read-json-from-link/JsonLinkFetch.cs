using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_json_from_link
{
    class JsonLinkFetch
    {
        public Product[] products { get; set; }

        public void DisplayProducts()
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"Product ID: {p.id}");
                Console.WriteLine($"Title: {p.title}");
                Console.WriteLine($"Description: {p.description}");
                Console.WriteLine($"Price: {p.price}");
                Console.WriteLine($"Discount: {p.discountPercentage}%");
                Console.WriteLine($"Rating: {p.rating}");
                Console.WriteLine($"In stock: {p.stock}");
                Console.WriteLine($"Brand: {p.brand}");
                Console.WriteLine($"Category: {p.category}\n\n");

                //Console.WriteLine($"Thumbnail: {p.thumbnail}");
                //foreach (string img in p.images)
                //{
                //    Console.WriteLine($"Images: {img}");
                //}
            }
        }

    }
    class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public float discountPercentage { get; set; }
        public float rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string thumbnail { get; set; }
        public string[] images { get; set; }
    }
}
