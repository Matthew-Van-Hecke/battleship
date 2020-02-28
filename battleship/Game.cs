using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Game
    {
        //Member Variables
        Random masterRandom;
        Player playerOne;

        //Constructor
        public Game()
        {
            masterRandom = new Random();
        }

        //Member Methods
        public void PlayGame()
        {
            Console.SetWindowSize(170, 40);
            playerOne = new Human(masterRandom);
            playerOne.MyGameBoard.PrintBoard();
            //Print rules
            //Instantiate two players (each will have a board in the form of a two-dimensional array, and a list of ships)
            //Let players pick their names
            //Allow each player to position their ships their board
            //Player one places ships, hits enter, and the console clears but his board is updated to reflect ship placement
            //Player two does the same
            //Player one's turn begins.
            //Print player one's board
            //Print what player two's board
            //He picks a position on player two's board

            //If picked position is occupied by one of player two's ships, register it as a hit, and subtract 1 from length of hit ship.
            //Otherwise, register it as a miss.
            //Repeat steps for player two
            //Keep alternating player's turns until one of the players has sunk all of the other player's ships
            //When this happens, declare player who has sunk all of the other player's ships the winner
            //Offer option to play again.
        }
    }
}
