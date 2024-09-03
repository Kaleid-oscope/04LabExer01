using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    internal class AppleCost
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Apple Market-----------");
            Console.WriteLine("Price: 17.64/apple"); double price = 17.64;
            Console.WriteLine(" ");

            Console.Write("Enter how many apples you want to purchase: ");
            int apples = Convert.ToInt32(Console.ReadLine());
            double total = price * apples;
            double floor = Math.Floor(total);
            Console.WriteLine(" ");

            Console.WriteLine("Amount of " + apples + " apples is: " + total);
            Console.WriteLine("Converted price is: " + floor); Console.WriteLine(" ");
        }
    }
}
