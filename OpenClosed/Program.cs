using OpenClosed;

var customers = new List<Customer>();
var goldenCustomer = new GoldenCustomer { Price = 100 };
var silverCustomer = new SilverCustomer { Price = 100 };

customers.Add(goldenCustomer);
customers.Add(silverCustomer);

foreach(var customer in customers)
{
    Console.WriteLine(customer.CalculateDiscount());
}