using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Casino;
using Casino.Blackjack;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("come play blackjack. what is your name");
            string playerName = Console.ReadLine();
            int bank = 0;
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("how much you going to put down");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("enter an integer only");
                }
            }
            
            Console.WriteLine("{0}, Do you want to play", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\David\Documents\Basic_C#_Programs\blackjack\blackjack\logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }
                Game game = new Blackjack();
                game = game + player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("security is incoming");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("errors occurred try again later");
                        return;
                    }
                    
                }
                game = game - player;
                Console.WriteLine("thank you for playing");

            }
            Console.WriteLine("try playing -- cheapskate");
        }
        
        
    }
}
