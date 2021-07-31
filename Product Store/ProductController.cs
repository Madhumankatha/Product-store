using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product_Store
{
    class ProductController
    {

        private List<Product> products;

        public ProductController()
        {
            products = new List<Product>();
        }

        public void addItem(Product product)
        {
            products.Add(product);
        }

        public void displayAll()
        {
            products.ForEach(p => display(p));
        }

        public void display(Product p) {
            Console.WriteLine("-------------");

            Console.WriteLine("id : " + p.id);
            Console.WriteLine("Name : " + p.name);
            Console.WriteLine("price: " + p.price);

            Console.WriteLine("-------------");
        }

        public Product search(String name)
        {
            return products.SingleOrDefault(p => p.name == name);
        }

        public void sort()
        {
            products.Sort((p1, p2) => p1.id.CompareTo(p2.id));
        }


        public void deleteItem(int index)
        {
            products.RemoveAt(index);
        }
    }
}
