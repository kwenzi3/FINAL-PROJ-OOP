using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add a Vehicle!");
            Console.WriteLine("1. Add a Worker!");
            Console.WriteLine("1. Add a Package!");
            Console.WriteLine("2. Assign Delivery/Deliveries");
            Console.WriteLine("3. Sort");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Run stimulation");
            Console.WriteLine("6. Undo");
            Console.WriteLine("7. Save or Load");

            Console.WriteLine("What is your option?");
            int choice =int.Parse(Console.ReadLine());
        }
    }
}
