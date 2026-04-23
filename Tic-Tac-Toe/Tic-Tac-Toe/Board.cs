using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe {
    internal class Board {


        private char[] board;

        public Board() {
            this.board = new char[] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
    }

        public char[] GetBoard() {
            return this.board;
        }

        public void SetBoardPawn(int position, char pawn) {
            this.board[position] = pawn;
        }

        public void BuildBoard(Game game) {
            
            Console.WriteLine("\n\n\n");
            Console.Write("\t\t\t\t");
            Console.Write("   |  " + "   |  \n");
            Console.Write("\t\t\t\t");
            Console.Write(board[0] + "  |  " + board[1] + "  |  " + board[2]);
            Console.Write("\n\t\t\t     ------|-----|------      \n");
            Console.Write("\t\t\t\t");
            Console.Write(board[3] + "  |  " + board[4] + "  |  " + board[5]);
            Console.Write("\n\t\t\t     ------|-----|------      \n");
            Console.Write("\t\t\t\t");
            Console.Write(board[6] + "  |  " + board[7] + "  |  " + board[8]);
            Console.Write("\n\t\t\t\t");
            Console.Write("   |  " + "   |  \n");
            Console.WriteLine("\n\n\n");
            if (game.Winner == null) {
                Console.WriteLine("Typing a numeber from 1 to 9 you can choose the place where you want to place your pawn\n");
            }

        }
    }
}

