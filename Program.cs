using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // System.Console.WriteLine("Welcome to SlapJack! Type: AddPlayer to add another player, and StartGame when you're ready to begin.");
        System.Console.WriteLine("Welcome to SlapJack! Type: Please enter player names.");
        System.Console.WriteLine("Player 1:");
        string screenname = Console.ReadLine();
        Player Player1 = new Player(1, screenname);
        System.Console.WriteLine("Player 2:");
        screenname = Console.ReadLine();
        Player Player2 = new Player(2, screenname);
        System.Console.WriteLine("Player 3:");
        screenname = Console.ReadLine();
        Player Player3 = new Player(3, screenname);
        // int id = 1;
        // string res = Console.ReadLine();
        // switch(res){
        //     case "AddPlayer":
        //     System.Console.WriteLine("Please Enter Your Name");
        //         string screenname = Console.ReadLine();
        //         Player  = new Player(screenname);
        //         id ++;
        //     }
            // Player Player1 = new Player(1, "Joe");
            // Player Player2 = new Player(2, "James");
            // Player Player3 = new Player(3, "Jason");
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();
            int cardcount = 52;
            while (cardcount > 0){
                Player1.DrawFrom(gameDeck);
                    if(cardcount <= 0){
                        break;
                    }
                cardcount --;
                Player2.DrawFrom(gameDeck);
                    if(cardcount <= 0){
                        break;
                    }
                cardcount --;
                Player3.DrawFrom(gameDeck);
                    if(cardcount <= 0){
                        break;
                    }
                cardcount --;
            }
            System.Console.WriteLine(Player1.hand);   
            Stack theStack = new Stack();
            string playfunction = "";
            // int activeplayer = new int();
            bool Player1Status = true;
            bool Player2Status = true;
            bool Player3Status = true;
            bool gameLoop = true;

            while(gameLoop == true)
            {
                if(Player1Status == true){
                    if(Player1.hand.Count > 51){
                        System.Console.WriteLine("*************************************");
                        System.Console.WriteLine("{0} is the winner!",Player1.name);
                        System.Console.WriteLine("*************************************");                    
                    }
                    System.Console.WriteLine(Player1.name + " (Player 1)'s Turn");
                    System.Console.WriteLine("Type FLIP to play a card");
                    playfunction = Console.ReadLine();
                    while(playfunction != "FLIP"){
                        System.Console.WriteLine("Improper Command. Type FLIP to play a card");
                        playfunction = Console.ReadLine();
                    }
                        System.Console.WriteLine("**********************************");
                        Card cardresult1 = theStack.GetCardFrom(Player1);
                        System.Console.WriteLine("**********************************");
                        if (cardresult1.ToString() == "Jack of Diamonds" || cardresult1.ToString() == "Jack of Hearts" || cardresult1.ToString() == "Jack of Spades" || cardresult1.ToString() == "Jack of Clubs"  )
                        {
                            System.Console.WriteLine("You played a Jack! Press key to slap. Player 1: A, Player 2: H, Player 3: L");
                            string result = Console.ReadLine();
                            if(result == "a"){
                                System.Console.WriteLine();
                                theStack.Take(Player1);
                                System.Console.WriteLine("{0} wins the stack!", Player1.name);
                            }
                            else if(result == "h"){
                                theStack.Take(Player2);
                               System.Console.WriteLine("{0} wins the stack!", Player2.name);
                            }
                            else if(result == "l"){
                                theStack.Take(Player3);
                               System.Console.WriteLine("{0} wins the stack!", Player3.name);
                            }                        
                        }
                        System.Console.WriteLine(Player1.hand.Count);
                        if(Player1.hand.Count < 1){
                            Player1Status = false;
                            System.Console.WriteLine("*************************************");
                            System.Console.WriteLine("{0} is the winner!",Player2.name);
                            System.Console.WriteLine("*************************************");
                        }
                }

// Player 2 turn

                if(Player2Status == true){
                    if(Player2.hand.Count > 51){
                        System.Console.WriteLine("*************************************");
                        System.Console.WriteLine("Player 2 is the winner!");
                        System.Console.WriteLine("*************************************");                    
                    }
                    System.Console.WriteLine(Player2.name + " (Player 2)'s Turn");
                    System.Console.WriteLine("Type FLIP to play a card");
                    playfunction = Console.ReadLine();
                    while(playfunction != "FLIP"){
                        System.Console.WriteLine("Improper Command. Type FLIP to play a card");
                        playfunction = Console.ReadLine();
                    }
                        System.Console.WriteLine("**********************************");
                        Card cardresult2 = theStack.GetCardFrom(Player2);
                        System.Console.WriteLine("**********************************");
                        if (cardresult2.ToString() == "Jack of Diamonds" || cardresult2.ToString() == "Jack of Hearts" || cardresult2.ToString() == "Jack of Spades" || cardresult2.ToString() == "Jack of Clubs"  )
                        {
                            System.Console.WriteLine("You played a Jack! Press key to slap. Player 1: A, Player 2: H, Player 3: L");
                            string result = Console.ReadLine();
                            if(result == "a"){
                                theStack.Take(Player1);
                               System.Console.WriteLine("{0} wins the stack!", Player1.name);
                            }
                            else if(result == "h"){
                                theStack.Take(Player2);
                                System.Console.WriteLine("{0} wins the stack!", Player2.name);
                            }
                            else if(result == "l"){
                                theStack.Take(Player3);
                            System.Console.WriteLine("{0} wins the stack!", Player3.name);
                            }                        
                        }
                        System.Console.WriteLine(Player2.hand.Count);
                        if(Player2.hand.Count < 1){
                            Player2Status = false;
                            System.Console.WriteLine("*************************************");
                            System.Console.WriteLine("Player 2 is out of the game");
                            System.Console.WriteLine("*************************************");
                        }
                }

    // Player 3 turn

               if(Player3Status == true){
                    if(Player3.hand.Count > 51){
                        System.Console.WriteLine("*************************************");
                        System.Console.WriteLine("{0} is the winner!",Player3.name);
                        System.Console.WriteLine("*************************************");                    
                    }
                    System.Console.WriteLine(Player3.name + " (Player 3)'s Turn");
                    System.Console.WriteLine("Type FLIP to play a card");
                    playfunction = Console.ReadLine();
                    while(playfunction != "FLIP"){
                        System.Console.WriteLine("Improper Command. Type FLIP to play a card");
                        playfunction = Console.ReadLine();
                    }
                        
                        System.Console.WriteLine("**********************************");
                        Card cardresult3 = theStack.GetCardFrom(Player3);
                        System.Console.WriteLine("**********************************");
                        if (cardresult3.ToString() == "Jack of Diamonds" || cardresult3.ToString() == "Jack of Hearts" || cardresult3.ToString() == "Jack of Spades" || cardresult3.ToString() == "Jack of Clubs"  )
                        {
                            System.Console.WriteLine("You played a Jack! Press key to slap. Player 1: A, Player 2: H, Player 3: L");
                            string result = Console.ReadLine();
                            if(result == "a"){
                                theStack.Take(Player1);
                                System.Console.WriteLine("{0} wins the stack!", Player1.name);
                            }

                            else if(result == "h"){
                                theStack.Take(Player2);
                                System.Console.WriteLine("{0} wins the stack!", Player2.name);
                            }
                            else if(result == "l"){
                                theStack.Take(Player3);
                                System.Console.WriteLine("{0} wins the stack!", Player3.name);
                            }                        
                        }
                        System.Console.WriteLine(Player3.hand.Count);
                        if(Player3.hand.Count < 1){
                            Player3Status = false;
                            System.Console.WriteLine("*************************************");
                            System.Console.WriteLine("Player 3 is out of the game");
                            System.Console.WriteLine("*************************************");
                        }
                }
                // if(pile[0] == "Jack of Hearts"){
                // break;
                // }

                // theStack.Take();

                // if(Player1.hand.Count  0)      
            // gameLoop = false;
        
            } //gameLoop
        } //main
    } //program
} //namespace