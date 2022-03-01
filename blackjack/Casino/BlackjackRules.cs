using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Casino.Blackjack
{
    public class BlackjackRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.two] = 2,
            [Face.three] = 3,
            [Face.four] = 4,
            [Face.five] = 5,
            [Face.six] = 6,
            [Face.seven] = 7,
            [Face.eight] = 8,
            [Face.nine] = 9,
            [Face.ten] = 10,
            [Face.jack] = 10,
            [Face.queen] = 10,
            [Face.king] = 10,
            [Face.ace] = 1,
        };
        private static int[] _GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)
            {
                value = value + (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool checkForBlackjack (List<Card> Hand)
        {
            int[] possibleValues = _GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;

        }
        public static bool isBusted(List<Card> Hand)
        {
            int value = _GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool shouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = _GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) return true;
            }
            return false;
        }
        public static bool? didPlayerWin (List<Card> playerHand, List<Card> dealerHand)
        {
            List<int> possiblePlayerHands = new List<int>();
            int[] arrayOfHands = BlackjackRules._GetAllPossibleHandValues(playerHand);
            int[] arrayOfDealerHands = BlackjackRules._GetAllPossibleHandValues(dealerHand);
            int bestDealerHand = arrayOfDealerHands.Where(x => x < 22).Max();
            int bestPlayerHand = arrayOfHands.Where(x => x < 22).Max();
            if (bestPlayerHand > bestDealerHand)
            {
                return true;
            }
            else if (bestPlayerHand < bestDealerHand) return false;
            else return null;
            
            
            
        }
        
    }
}
