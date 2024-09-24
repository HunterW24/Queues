using Queues;
using System;
using System.Collections.Generic;

namespace Queues_Wixson_Hunter
{

    // Represents the main entry point of the application.
    class Program
    {
        // The main method is the starting point of the program.
        static void Main(string[] args)
        {
            // Create a new game instance with a maximum of 50 players and currently 49 players.
            Game myGame = new Game(50, 49);

            // Create a queue to store players waiting to join the game.
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            // Create some player instances.
            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "SulfurHex24");
            Player p3 = new Player(100, "AimedBat7216127");
            Player p4 = new Player(100, "Jayden4458");

            // Add the players to the waiting queue.
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);


            // Print the players currently in the queue.
            Console.WriteLine("Players in the Queue");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            // Kick a player from the game.
            myGame.KickPlayer();

            // Check if there are available slots and process the queue.
            myGame.CheckQueue(waitingToJoinQ);

            // Print the players remaining in the queue after the check.
            Console.WriteLine("\nPlayers in the Queue: ");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }


}