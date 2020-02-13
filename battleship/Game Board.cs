using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class GameBoard
    {
        //Member Variables
        int width;
        int height;
        string[][] board;
        //Constructor
        public GameBoard(int width, int height)
        {
            this.width = width;
            this.height = height;
            board = new string[height][];
            for (int i = 0; i < height; i++)
            {
                board[i] = new string[width];
                for (int j = 0; j < width; j++)
                {
                    board[i][j] = "O";
                }
                Console.WriteLine("\n");
            }
        }
        //Member Methods
        public void PrintBoard()
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(i + " -\t");
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write(board[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
