using System;
using System.Collections.Generic;
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

        public void display()
        {
            foreach (Product p in products)
            {
                Console.WriteLine("-------------");

                Console.WriteLine("id : " + p.id);
                Console.WriteLine("Name : " + p.name);
                Console.WriteLine("price: " + p.price);

                Console.WriteLine("-------------");
            }
        }

        public void sortList()
        {

        }
    }
}
