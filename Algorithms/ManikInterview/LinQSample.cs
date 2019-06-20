using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class LinQSample
    {
        public LinQSample()
        {
            var apple = new Product { Name = "Apple" };
            var orange = new Product { Name = "Orange" };
            var bread = new Product { Name = "Bread" };
            var customers = new[] {
                                    new Customer { Name = "Alexey", Orders = new[] {
                                                                                    new Order { Product = apple, Quantity = 10 },
                                                                                    new Order { Product = orange, Quantity = 5 } }.ToList() },
                                    new Customer { Name = "Andrey", Orders = new[] {
                                                                                    new Order { Product = bread, Quantity = 5 },
                                                                                    new Order { Product = orange, Quantity = 2 } }.ToList() },
                                    new Customer { Name = "Alexandr", Orders = new[] {
                                                                                    new Order { Product = apple, Quantity = 10 } }.ToList() }
            }.ToList();


        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
    }
}