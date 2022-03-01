using System;
using System.Collections.Generic;
using System.Linq;

namespace Casino
{
    public struct Card
    {
        public Face Face { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
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
