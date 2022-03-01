using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Casino.Blackjack
{
    public class Blackjack : Game, IWalkAway
    {
        BlackjackDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach ( Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            
            foreach (Player player in Players)
            {
                int bet = 0;
                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.WriteLine("place your bet");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer)
                    {
                        Console.WriteLine("enter an integer only");
                    }
                }
                if (bet < 1)
                {
                    throw new FraudException("Security is incoming");
                }
                bool successfullyBet = player.Bet(bet);
                if(!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing ...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if(i == 1)
                    {
                        bool blackJack = BlackjackRules.checkForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("WINNER WINNER {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if(i == 1)
                {
                    bool blackJack = BlackjackRules.checkForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer wins you all lose");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;

                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "stay")
                        {
                            player.Stay = true;
                            break;
                        }
                        else if (answer == "hit")
                        {
                            Dealer.Deal(player.Hand);
                        }
                        bool busted = BlackjackRules.isBusted(player.Hand);
                        if (busted)
                        {
                            Dealer.Balance += Bets[player];
                            Console.WriteLine("{0} Busted! you lose your bet of {1}, your balance is now {2}", player.Name, Bets[player], player.Balance);
                            Console.WriteLine("do you want to play again?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "y")
                            {
                                player.isActivelyPlaying = true;
                                return;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                                return;
                            }
                               
                        }
                    
                }
            }
            Dealer.isBusted = BlackjackRules.isBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.shouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackjackRules.isBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.shouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
                if (Dealer.isBusted)
                {
                    Console.WriteLine("Dealer Busted!");
                    foreach (KeyValuePair<Player, int> entry in Bets)
                    {
                        Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                        Dealer.Balance -= entry.Value;
                    }
                    return;
                }
                foreach (Player player in Players)
                {
                    bool? playerWon = BlackjackRules.didPlayerWin(player.Hand, Dealer.Hand);
                    if(playerWon == null)
                    {
                        Console.WriteLine("No one wins");
                        player.Balance += Bets[player];
                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0} won. you win {1}", player.Name, Bets[player]);
                        player.Balance += Bets[player] * 2;
                        Dealer.Balance -= Bets[player];
                    }
                    else
                    {
                        Console.WriteLine("dealer wins {0}", Bets[player]);
                        Dealer.Balance += Bets[player];
                        
                    }
                    Console.WriteLine("play again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "y")
                    {
                        player.isActivelyPlaying = true;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                    }
                }
                
            }

        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

        


    }
}
