using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    public class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomer
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();


            Customer c1 = new Customer { Custid = 101, Name = "Nayan", City = "Indore", Balance = 25002.00 };
            Customer c2 = new Customer { Custid = 102, Name = "Rajesh", City = "Bhopal", Balance = 200002.00 };
            Customer c3 = new Customer { Custid = 103, Name = "Nandu", City = "Bangalore", Balance = 35002.00 };
            Customer c4 = new Customer { Custid = 104, Name = "Sudha", City = "Purnea", Balance = 400000.00 };

            Customers.Add(c1); Customers.Add(c2);
            Customers.Add(c3); Customers.Add(c4);

            foreach (Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }
            Console.ReadLine();
        }
    }
}

