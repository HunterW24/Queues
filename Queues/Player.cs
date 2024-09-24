using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    // Represents a player in the game.
    public class Player
    {
        // The player's health points.
        public int Health { get; set; }

        // The player's unique identifier or username.
        public string GamerTag { get; }

        // Constructor to create a new player with the specified health and gamer tag.
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        // Attempts to join the specified game, adding the player to the queue if the game is full.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                // If the game is full, add the player to the waiting queue.
                queue.Enqueue(this);
            }
            else
            {
                // If there's room, join the game and increment the current player count.
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        // Overridden ToString method to provide a string representation of the player.
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
