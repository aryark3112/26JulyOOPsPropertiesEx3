using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Read and Write EXAMPLE 1
            //Customer customer = new Customer();
            //Console.WriteLine("*** Default Values");
            //Console.WriteLine($"Customer ID :{customer.Id} Name: {customer.Name} MembershipEndDate{customer.MEndDate}");
            //Console.WriteLine("Enter Customer ID");
            //customer.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Customer name");
            //customer.Name = Console.ReadLine();
            //Console.WriteLine("Enter Customer Membership End Date");
            //customer.MEndDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Stored Record As Follows!!!");
            //Console.WriteLine($"Customer ID :{customer.Id} Name: {customer.Name} MembershipEndDate {customer.MEndDate}" );

            //READOMLY EXAMPLE 2
            //Customer customer= new Customer(12, "Raj", new DateTime(day: 09, month: 02, year: 2024));
            //Console.WriteLine("Customer Details as follows");
            //Console.WriteLine($"Customer Id :{customer.Id} Nmae:" + $" {customer.Name} MembershipEndDate {customer.MEndDate}");
            //Console.ReadKey();

            //Write Only Example3
            Customer customer = new Customer(12, "Raj", new DateTime(day: 09, month: 02, year: 2024));
            Console.WriteLine("Customer Details as follows");
            Console.WriteLine($"Customer Id :{customer.Id} Nmae:" + $" {customer.Name} MembershipEndDate {customer.MEndDate}");
            customer.Comment = "I am delighted with the services provided by the vendor";
            customer.ReadComment("admin@123");
            Console.ReadKey();

        }
    }
}
