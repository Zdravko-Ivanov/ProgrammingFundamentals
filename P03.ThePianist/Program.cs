using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace P03.ThePianist
{
    class Piece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public Piece(string name, string composer, string key)
        {
            this.Name = name;
            this.Composer = composer;
            this.Key = key;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            List<Piece> list = new List<Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];
                list.Add(new Piece(name, composer, key));
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                if (command.StartsWith("Add"))
                {
                    string[] pieces = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    string name = pieces[1];
                    string composer = pieces[2];
                    string key = pieces[3];
                    bool ifExist = false;

                    foreach (var piece in list)
                    {
                        if (piece.Name == name)
                            ifExist = true;
                    }

                    if (!ifExist)
                    {
                        list.Add(new Piece(name, composer, key));
                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    }
                    else Console.WriteLine($"{name} is already in the collection!");

                }
                else if (command.StartsWith("Remove"))
                {
                    string name = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[1];
                    bool ifExist = false;

                    foreach (var piece in list)
                    {
                        if (piece.Name == name)
                        {
                            Console.WriteLine($"Successfully removed {name}!");
                            list.Remove(piece);
                            ifExist = true;
                            break;
                        }
                    }
                    if (!ifExist)
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                }

                else if (command.StartsWith("ChangeKey"))
                {
                    string name = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[1];
                    string key = command.Split("|", StringSplitOptions.RemoveEmptyEntries)[2];
                    bool ifExist = false;
                    foreach (var piece in list)
                    {
                        if (piece.Name == name)
                        {
                            Console.WriteLine($"Changed the key of {name} to {key}!");
                            piece.Key = key;
                            ifExist = true;
                            break;
                        }
                    }
                    if (!ifExist)
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                }
            }

            foreach (var piece in list)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }
    }
}
