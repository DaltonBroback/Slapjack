using System;
using System.Collections.Generic;

namespace DeckOfCards{
    public class Stack{
        private List<Card> pile;
        public Stack(){
            pile = new List<Card>();
        }
        public Card GetCardFrom(Player currentPlayer){
            pile.Insert(0,currentPlayer.Flip());
            System.Console.WriteLine("\n"+ pile[0]+"\n");
            return pile[0];
        }
        public void Take(Player winner){
            foreach(Card guy in pile){
                winner.hand.Add(guy);
            }
            pile.Clear();
        }

        // public void Shuffle(){
        //     Random rand = new Random();
        //     for(int idx = pile.Count -1; idx > 0; idx--){
        //         int randIdx = rand.Next(idx);
        //         Card temp = pile[randIdx];
        //         pile[randIdx] = pile[idx];
        //         pile[idx] = temp;
        //     }
        // }

        public override string ToString(){
            string info = "";
            foreach (Card card in pile){
                info += card + "\n";
            }
            return info;
        }
    }
}

        // public void DrawFrom(Deck currentDeck){
        //     hand.Add(currentDeck.Deal());
        // }
