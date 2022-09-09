using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gameBoard = Console.ReadLine().Split().ToList();
            int winMoves = 1;
            string[] moves = Console.ReadLine().Split();
            bool isWon = false;

            while (moves[0] != "end")
            {

                int firstMatchedElement = int.Parse(moves[0]);
                int secondMatchedElement = int.Parse(moves[1]);

                if (firstMatchedElement >= 0 && firstMatchedElement < gameBoard.Count && secondMatchedElement >= 0 && secondMatchedElement < gameBoard.Count && firstMatchedElement != secondMatchedElement)
                {
                    if (gameBoard[firstMatchedElement] == gameBoard[secondMatchedElement])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {gameBoard[firstMatchedElement]}!");
                        gameBoard.RemoveAt(Math.Max(firstMatchedElement, secondMatchedElement));
                        gameBoard.RemoveAt(Math.Min(secondMatchedElement, firstMatchedElement));
                    }
                    else
                        Console.WriteLine("Try again!");
                }
                else
                {
                    gameBoard.Insert(gameBoard.Count / 2, "-" + winMoves + "a");
                    gameBoard.Insert(gameBoard.Count / 2, "-" + winMoves + "a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                if (gameBoard.Count == 0)
                {
                    Console.WriteLine($"You have won in {winMoves} turns!");
                    isWon = true;
                    break;
                }

                winMoves++;
                moves = Console.ReadLine().Split();
            }

            if (!isWon)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", gameBoard));
            }
            }
        }
}
