using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    class Items
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Cal { get; set; }
        public Items(string name, string date, int cal)
        {
            this.Name = name;
            this.Date = date;
            this.Cal = cal;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)(?<name>[A-Za-z\s]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<cal>\d+)\1";

            string inputLine = Console.ReadLine();

            Match itemMatched = Regex.Match(inputLine, pattern);

            List<Items> items = new List<Items>();

            while (itemMatched.Success)
            {
                items.Add(new Items(itemMatched.Groups["name"].ToString(),
                    itemMatched.Groups["date"].ToString(),
                    int.Parse(itemMatched.Groups["cal"].ToString())));
                itemMatched = itemMatched.NextMatch();
            }

            Console.WriteLine($"You have food to last you for: {items.Sum(x => x.Cal) / 2000} days!");

            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Best before: {item.Date}, Nutrition: {item.Cal}");
            }


        }
    }
}
