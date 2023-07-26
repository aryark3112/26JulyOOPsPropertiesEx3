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
            Customer customer = new Customer();
            Console.WriteLine("*** Default Values");
            Console.WriteLine($"Customer ID :{customer.Id} Name: {customer.Name} MembershipEndDate{customer.MEndDate}");
            Console.WriteLine("Enter Customer ID");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Membership End Date");
            customer.MEndDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Stored Record As Follows!!!");
            Console.WriteLine($"Customer ID :{customer.Id} Name: {customer.Name} MembershipEndDate {customer.MEndDate}" );
            Console.ReadKey();
        }
    }
}
