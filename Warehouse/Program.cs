using System;
using Warehouse.Models.Enums;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            string order1 = order.IssueOrder((int)SupplierNames.Enko, 2, 16);
            string order2 = order.IssueOrder((int)SupplierNames.MTI, 5, 10);
            string order3 = order.IssueOrder((int)SupplierNames.Scholz, 1, 50);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
            Console.ReadLine();

            string processOrder1 = order.ProcessOrder(5,10);
            string processOrder2 = order.ProcessOrder(2, 16);
            string processOrder3 = order.ProcessOrder(5, 16);
            Console.WriteLine(processOrder1);
            Console.WriteLine(processOrder2);
            Console.WriteLine(processOrder3);
            Console.ReadLine();            
        }
    }
}
