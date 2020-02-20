using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    abstract class Player
    {
        //Member variables
        GameBoard myGameBoard;
        public GameBoard MyGameBoard
        {
            get { return myGameBoard; }
        }
        GameBoard opponentGameBoard;
        List<Ship> myShips;
        List<Ship> shipsISunk;
        public int score;
        Random random;
        //Constructor
        public Player(Random random)
        {
            this.random = random;
            score = 0;
            //Create 2d arrays for 20x20 board here. These boards will change to reflect other player's moves
            myGameBoard = new GameBoard(20, 20);
            opponentGameBoard = new GameBoard(20, 20);
            myShips = new List<Ship>() { new Ship("Destroyer", 2), new Ship("Submarine", 3), new Ship("Battleship", 4), new Ship("Aircraft Carrier", 5)};
        }
        //Member Methods
        public List<GameBoard> ReceiveShot(GameBoard attackersRecordOfBoard, GameBoard boardBeingAttacked, int shotCoordinateY, int shotCoordinateX)
        {
            List<GameBoard> resultGameBoards = new List<GameBoard>();
            //Take in shot coordinates.
            if (boardBeingAttacked.board[shotCoordinateY][shotCoordinateY] == "O")
            {
                //Look at coordinates on board being attack to see if anything is there.
                boardBeingAttacked.board[shotCoordinateY][shotCoordinateX] = "1";
                attackersRecordOfBoard.board[shotCoordinateY][shotCoordinateX] = "1";
                //If something is there, mark both boards with a hit, and subtract 1 from length of ship.
            }
            //Add both adjusted boards to list of resulting game boards
            resultGameBoards.Add(attackersRecordOfBoard);
            resultGameBoards.Add(boardBeingAttacked);
                return resultGameBoards;
        }
        public abstract void PlaceAShip(int shipLength);
    }
}
