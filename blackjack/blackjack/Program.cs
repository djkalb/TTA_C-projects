using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("come play blackjack. what is your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("how much you going to put down");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}, Do you want to play", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer = "yes" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new Blackjack();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

            }
        }
        
        
    }
}
