using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Player
    {
        //Member variables
        public string[] myGameBoard;
        public string[] opponentGameBoard;
        public int score;
        List<Ship> myShips;
        List<Ship> opponentShipsISunk;
        //Constructor
        public Player()
        {
            //Create 2d arrays for 20x20 board here. These boards will change to reflect other player's moves
            myGameBoard = new string[20];
            opponentGameBoard = new string[20];
            myShips = new List<Ship>() { new Ship("Destroyer", 2), new Ship("Submarine", 3), new Ship("Battleship", 4), new Ship("Aircraft Carrier", 5)};
        }
        //Member Methods
                //Print boards. Take in 2d array as parameter.
    }
}
