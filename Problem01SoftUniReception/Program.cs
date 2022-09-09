using System;
using System.Drawing;

namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            bool isWon = false;
            int wonBattles = 0;
            string moves = Console.ReadLine();

            while (moves != "End of battle" && energy >= 0)
            {
                int battle = int.Parse(moves);

                if (energy - battle >= 0)
                {
                    wonBattles++;
                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                    energy -= battle;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    isWon = true;
                    break;
                }


  
                moves = Console.ReadLine();
            }

            if(!isWon)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
}
    }
}
