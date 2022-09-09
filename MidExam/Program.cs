using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProblemComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prices = Console.ReadLine();
            decimal sumWithoutTaxes = 0, totalPrice = 0; ;

            while (!(prices == "special" || prices == "regular"))
            {
                decimal currentPrice = decimal.Parse(prices);

                if (currentPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sumWithoutTaxes += currentPrice;
                }
                prices = Console.ReadLine();
            }

            decimal taxes = sumWithoutTaxes * 0.2M;

            if (prices == "special")
            {
                totalPrice = (sumWithoutTaxes + taxes) * 0.9M;
            }
            else
            {
                totalPrice = sumWithoutTaxes + taxes;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\r\n" +
                    $"Price without taxes: {sumWithoutTaxes:f2}$\r\n" +
                    $"Taxes: {taxes:f2}$\r\n" +
                    $"-----------\r\n" +
                    $"Total price: {totalPrice:f2}$\r\n"); 
            }



        }
    }
}
