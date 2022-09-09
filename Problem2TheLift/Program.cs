using System;
using System.Linq;

namespace Problem2TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4 && peopleInQueue > 0)
                {
                    wagons[i]++;
                    peopleInQueue--;
                }
            }

            if (peopleInQueue == 0 && wagons[wagons.Length -1] != 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (peopleInQueue > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue!");
            }

                Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
