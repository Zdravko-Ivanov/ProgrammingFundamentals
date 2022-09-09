using System;
using System.Text;

namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Decode")
            {
                if (command.StartsWith("Move"))
                {
                    int moveBy = int.Parse(command.Split("|", StringSplitOptions.RemoveEmptyEntries)[1]);
                    message = message.Substring(moveBy, message.Length - moveBy) +
                              message.Substring(0, moveBy);

                }
                else if (command.StartsWith("Insert"))
                {
                    int index = int.Parse(command.Split("|", StringSplitOptions.RemoveEmptyEntries)[1]);
                    string value = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[2];
                    message = message.Insert(index, value);
                }
                else if (command.StartsWith("ChangeAll"))
                {
                    string change = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[1];
                    string changeWith = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[2];

                    while (message.Contains(change))
                    {
                        message = message.Replace(change, changeWith);
                    }

                }
            }

            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}
