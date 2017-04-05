using System.Collections.Generic;

namespace DeckOfCards{
    public class Player{
        public int id;
        public string name;
        public List<Card> hand;
        public Player(int i, string n){
            hand = new List<Card>();
            name = n;
            id = i;
        }
        public void DrawFrom(Deck currentDeck){
            hand.Add(currentDeck.Deal());
        }

        public Card Flip(){
            if(hand.Count > 0){
                Card temp = hand[0];
                hand.RemoveAt(0);
                return temp;
            }
            return null;
        }
        public override string ToString(){
            string info = "";
            foreach (Card card in hand){
                info += card + "\n";
            }
            return info;
        // public Card Deal(){
        //     if(cards.Count > 0){
        //         Card temp = cards[0];
        //         cards.RemoveAt(0);
        //         return temp;
        //     }
        //     return null;
        // }
        // public Card Discard(int idx){
        //     Card temp = hand[idx];
        //     hand.RemoveAt(idx);
        //     return temp;
        }
    }
} 
