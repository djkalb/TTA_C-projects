using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    public class Card
    {
        public Face Face { get; set; }
        public Suit Suit { get; set; }
    }
    public enum Suit
    {
        clubs,
        diamonds,
        hearts,
        spades
           
    } 
    public enum Face
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }
}
