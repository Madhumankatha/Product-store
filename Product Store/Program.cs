using System;
using System.Collections.Generic;

namespace Product_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            ProductController controller = new ProductController();

            Console.WriteLine("------------ PRODUCT STORE ------------ \n");

            bool showMenu = true;

            Console.WriteLine("--- Console App ---- \n");

            while (showMenu)
            {
                Console.WriteLine("--- Select a option ----\n");
                Console.WriteLine("--- 1. Add Product ----\n");
                Console.WriteLine("--- 2. Display all Products ----\n");
                Console.WriteLine("--- 3. Delete a Product ----\n");
                Console.WriteLine("--- 4. Search a Product ----\n");
                Console.WriteLine("--- 5. Sort ----\n");
                Console.WriteLine("--- 6. Exit----\n");
                Console.WriteLine("---  Enter a option----\n");
                int key = Int16.Parse(Console.ReadLine());

                if(key == 1)
                {
                    Console.WriteLine("Enter product id:");
                    int id = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter product name:");
                    String name = Console.ReadLine();

                    Console.WriteLine("Enter product price:");
                    int price = Int32.Parse(Console.ReadLine());

                    controller.addItem(new Product(){ id = id, name = name, price = price });
                    Console.WriteLine("Product added successfully");
                    Console.ReadLine();
                }
                else if(key == 2)
                {
                    controller.displayAll();
                    Console.ReadLine();
                }
                else if(key == 3)
                {
                    Console.WriteLine("Enter a product id:");
                    int positon = Int16.Parse(Console.ReadLine());
                    controller.deleteItem(positon);
                    Console.WriteLine("Product deleted successfully");
                    Console.ReadLine();
                }
                else if (key == 4)
                {
                    Console.WriteLine("Enter a product name:");
                    
                    Product product = controller.search(Console.ReadLine());
                    
                    if (product != null)
                    {
                        controller.display(product);
                    }
                    else
                    {
                        Console.WriteLine("No Product Found!!");
                    }

                    Console.WriteLine("Product Search");
                    Console.ReadLine();

                }
                else if (key == 5)
                {
                    controller.sort();
                    Console.ReadLine();
                }
                else if(key == 6)
                {
                    Environment.Exit(0);

                }

            }

        }
    }
}
