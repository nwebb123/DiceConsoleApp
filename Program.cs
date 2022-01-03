using System;

namespace DiceConsoleApp
{
    internal class DiceGame
    {
        static void Main(string[] args)
        {
            //Greet the player
            Console.WriteLine("Hello and welcome to the Dice Game. Press spacebar to roll the dice. Good luck!");

            //Take input from user to roll dice (spacebar)
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {

                Random random = new Random();

                int diceOne = 0;

                int diceTwo = 0;

                for (int i = 0; i < 1000000000; i++)
                {

                    diceOne = random.Next(1, 7);
                    diceTwo = random.Next(1, 7);

                    Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}.");

                    Console.WriteLine("Press spacebar to roll again.");

                    Console.ReadKey();
                }
              
            }
            else
            {
                Console.WriteLine("Try hitting spacebar to roll the dice.");

                Console.ReadKey();
            }

        }
    }
}
