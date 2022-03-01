using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public int Balance { get; set; }

        public void  Deal(List<Card> Hand)
        {
            
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\David\Documents\Basic_C#_Programs\blackjack\blackjack\logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
            
            
        }
    }
}
