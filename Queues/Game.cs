using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    // Represents a game object within the current assembly (internal visibility).
    internal class Game
    {
        // The maximum number of players allowed in the game.
        public int MaxPlayers { get; }

        // The current number of players in the game.
        public int CurrentPlayers { get; set; }

        // Constructor to initialize the game with the specified maximum and current player counts.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        // Decrements the current player count by 1, simulating a player being kicked.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        // Checks if there are available slots in the game and processes the player queue accordingly.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // If there are available slots...
            if (CurrentPlayers < MaxPlayers)
            {
                // If there are players waiting in the queue...
                if (playerQueue.Count > 0)
                {
                    // TODO: Implement logic to add a player from the queue to the game.
                }
                else
                {
                    // If the queue is empty, print a message indicating no players are waiting.
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
