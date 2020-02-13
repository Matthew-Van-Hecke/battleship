using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard(12, 12);
            gameBoard.PrintBoard();
            Console.ReadLine();
        }
    }
}
