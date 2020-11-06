using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Create a card deck 

            //First Loop
            //TODO Count the players money in the title
            bool play = true;
            int playerMoney = 500;
            Console.Title = ($"Player Funds: {playerMoney:c}");
            //Switch Menu S)et your bet, D)eal a hand, A)dd Money, E)xit
            Console.WriteLine("Welcome honored gambler! Choose a selection from the menu below:\n" +
                "S)et your bet\n" +
                "D)eal a hand\n" +
                "A)dd more funds\n" +
                "E)xit the game\n");
            ConsoleKey playerChoice = Console.ReadKey(true).Key;
            do
            {


                switch (playerChoice)
                {
                    case ConsoleKey.S:
                        //TODO Functionality first bet
                        break;
                    case ConsoleKey D:
                        do
                        {//TODO Second Loop
                         //TODO Check Player for blackjack
                         //TODO Player choice stay or hit
                            Console.WriteLine("Would you like to H)it or S)tay?");
                            ConsoleKey choice2 = Console.ReadKey(true).Key;
                            switch (choice2)
                            {
                                case ConsoleKey.H:
                                    //TODO Hit Functionality - to select another card
                                    //TODO Dealer Hit Functionality

                                    break;
                                case ConsoleKey.S:
                                    //TODO Stay Functionality - to compare the hands
                                    //TODO Enter Dealer Loop - check dealer score vs bust

                                    break;
                                default:
                                    Console.WriteLine("You must make a choice from the menu noble gambler.");
                                    break;
                            }
                            if (hit)
                            {

                            }
                            else
                            {

                            }
                        } while (!bust || !blackjack);//TODO Randomly Select cards for the player hand
                        //TODO The Pot functionality - counting the money
                        if (bust)
                        {
                            //TODO Check for player bust - add console tones if player busts
                        }
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("How much would you like to add");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Come back when you have more money.");
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Input not recognized. Put down your drink and read the menu.");
                        break;
                }
            } while (play);













        }
    }
}
