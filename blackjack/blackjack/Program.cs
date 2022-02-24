using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Blackjack();
            //Deck deck = new Deck();
            //deck.Shuffle(2);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Game game = new Blackjack();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            //game = game - player;
            Deck deck = new Deck();
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " " + card.Suit);
            }
        }
        
        
    }
}
