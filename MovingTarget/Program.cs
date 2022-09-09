using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string actions = Console.ReadLine();

            while (actions != "End" && targets.Count >= 0)
            {
                string[] action = actions.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(action[1]);
                int value = int.Parse(action[2]);

                if (action[0] == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {

                        if (targets[index] - value > 0)
                        {
                            targets[index] -= value;
                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }

                else if (action[0] == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }

                else if (action[0] == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count)
                    {


                        targets.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                actions = Console.ReadLine();

            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
