using System;
namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Product product1 = new Product("5 pack, Customer Book Marks", "A123", 14.99, 5);
        Product product2 = new Product("Custom Page Stamp", "B456", 35.99, 1);
        Product product3 = new Product("Book Lover Tote", "C789", 25.99, 3);
        Product product4 = new Product("Fire Heart Necklace", "D111", 39.99, 2 );

        Address address1 = new Address("123 Storybrook Way", "Newport", "CA", "USA");
        Address address2 = new Address("789 Upon A Time Blvd", "Toronto", "ON", "Canada");
        Address address3 = new Address("456 Pages Lane", "Toronto", "ON", "Canada");
        Address address4 = new Address("2121 Reading Ct", "Essec", "CT", "USA");

        Customer customer1 = new Customer("Elise W.", address1);
        Customer customer2 = new Customer("Axel M.", address2);
        Customer customer3 = new Customer("Jamie F.", address3);
        Customer customer4 = new Customer("Julia S.", address4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product2);

        Order order4 = new Order(customer4);
        order4.AddProduct(product4);
        order4.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}");

        Console.WriteLine("Order 4:");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order4.GetTotalCost():F2}");
    }

    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order (Customer customer)
        {
            _customer = customer;
            _products = new List <Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            if (_customer.IsInUSA())
            {
                total += 5.00;
            }
            else
            {
                total += 35.00;
            }

            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Package lable:";

            foreach (Product product in _products)
            {
                label += $"{product.GetProductName()} (ID: {product.GetProductID()})";
            }

            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label: {_customer.GetCustomerName()} {_customer.GetAddress().GetFullAddress()}";
        }
    }
}