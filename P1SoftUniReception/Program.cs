using System;

namespace P1SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receptionistOne = int.Parse(Console.ReadLine());
            int receptionistTwo = int.Parse(Console.ReadLine());
            int receptionistThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = students / (receptionistOne + receptionistTwo + receptionistThree);
            int time = 0;
            //if (hours >= 4)
              //  time += hours/4;



            Console.WriteLine($"Time needed: {students % (receptionistOne + receptionistTwo + receptionistThree) + time}h.");
        }
    }
}
