using System;
using System.Collections.Generic;
namespace Milestone_2_assessment
{
    public class Product
    {
        //Private fields
        private string _name;
        private double _price;
        private string _category;
        
        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        //Constructor
        public Product(string name, double price, string category)
        {
            _name = name;
            _price = price;
            _category = category;
        }

    }

    public class User
    {

        //Private fields
        private string _username;
        private string _password;
        private string _email;

        //Public properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //Constructor
        public User(string username, string password, string email)
        {
            _username = username;
            _password = password;
            _email = email;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class Customer: Person
    {
        public Customer(string name, string email) : base(name, email) { }
        public void ShowCustomerDetails()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"Customer Name: {Name}, Email: {Email}");
        }
    }
    
    public class Admin: Person
    {
        public Admin(string name, string email) : base(name, email) { }
        public void ShowAdminDetails()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"Admin Name: {Name}, Email: {Email}");
        }
    }

    public class Order
    {
        public List<Product> Products { get; set; }
        public double TotalAmount { get; private set; }
        public Order()
        {
            Products = new List<Product>();
        }
        //Method Overloading
        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalAmount += product.Price;
        }
        public void AddProduct(Product product, int quantity)
        {
            Products.Add(product);
            TotalAmount += product.Price * quantity;
        }

        //Method Overriding
        public virtual double CalculateTotal()
        {
            return TotalAmount;
        }
        public virtual double CalculateTotal(double discount)
        {
            return TotalAmount - (TotalAmount * discount / 100);
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Order Summary:");
            foreach (var product in Products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine($"Total Amount: {TotalAmount}");
        }
    }
    
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);
        void CancelOrder(Order order);
    }

    public class PaymentProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Processing payment...");
            order.ShowOrderDetails();
        }
        public void CancelOrder(Order order)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Payment canceled.");
        }
    }
    
    public class ShippingProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Processing shipping...");
        }
        public void CancelOrder(Order order)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Shipping canceled.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //Create user
            Console.WriteLine("Enter username, password & email address of the user: ");
            User user = new User(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            //Create customer
            Console.WriteLine("Enter username & email address of the customer: ");
            Customer customer = new Customer(Console.ReadLine(), Console.ReadLine());
            //Create admin
            Console.WriteLine("Enter username & email address of the admin: ");
            Admin admin = new Admin(Console.ReadLine(), Console.ReadLine());
            customer.ShowCustomerDetails();
            admin.ShowAdminDetails();

            //Create products
            Console.WriteLine("=============================================");
            Console.WriteLine("Enter name, price & category of product 1: ");            
            Product product1 = new Product(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            Console.WriteLine("Enter name, price & category of product 2: ");
            Product product2 = new Product(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());


            //Create order and add products
            int qty;
            Order order = new Order();
            Console.WriteLine($"What quantity required for {product1.Name} ?");
            qty = Convert.ToInt32(Console.ReadLine());
            if (qty == 1)
                order.AddProduct(product1);
            else           
                order.AddProduct(product1, qty);

            Console.WriteLine($"What quantity required for {product2.Name} ?");
            qty = Convert.ToInt32(Console.ReadLine());
            if (qty == 1)
                order.AddProduct(product2);
            else
                order.AddProduct(product2, qty);
            //Display order details
            order.ShowOrderDetails();
            Console.WriteLine("=============================================");
            Console.WriteLine($"10% discount applicable (Y/N)?");
            string discountApplicable = Console.ReadLine();
            if(discountApplicable=="Y")
                Console.WriteLine($"Total Amount with 10% discount: {order.CalculateTotal(10)}");
            else
                Console.WriteLine($"Discount not applicable");

            //Process order
            IOrderProcessor paymentProcessor = new PaymentProcessor();
            Console.WriteLine("=============================================");

            Console.WriteLine($"Proceed with payment (Y/N)?");
            string processPayment = Console.ReadLine();
            if (processPayment == "Y")                
                paymentProcessor.ProcessOrder(order);
            else
                paymentProcessor.CancelOrder(order);
            //Ship order
            IOrderProcessor shippingProcessor = new ShippingProcessor();
            Console.WriteLine("=============================================");

            Console.WriteLine($"Proceed with shipping (Y/N)?");
            string processShipping = Console.ReadLine();
            if (processShipping == "Y")
                shippingProcessor.ProcessOrder(order);
            else
                shippingProcessor.CancelOrder(order);
        }
    }
}