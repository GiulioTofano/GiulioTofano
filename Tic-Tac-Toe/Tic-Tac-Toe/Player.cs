using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe {
    internal class Player {

        public String Name { get; set; }


        public void PlacePawn(Game game, int position) {
            bool moveDone = false;
            do {
                if (game.Turn.PlayerTurn == game.Player1 && (game.Board.GetBoard()[position] != 'X' && game.Board.GetBoard()[position] != 'O')) {
                    game.Board.SetBoardPawn(position, 'X');
                    moveDone = true;
                } else if (game.Turn.PlayerTurn == game.Player2 && (game.Board.GetBoard()[position] != 'X' && game.Board.GetBoard()[position] != 'O')) {
                    game.Board.SetBoardPawn(position, 'O');
                    moveDone = true;
                } else {
                    Console.WriteLine("Invalid move, you can't place upon another pawn. Please insert a new position :: ");
                    position = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                CheckForWin(game);
            } while (!moveDone);
        }


        public void CheckForWin(Game game) {

            if (


               game.Board.GetBoard()[0] == game.Board.GetBoard()[1] && game.Board.GetBoard()[1] == game.Board.GetBoard()[2] && game.Board.GetBoard()[0] != ' ' ||
               game.Board.GetBoard()[3] == game.Board.GetBoard()[4] && game.Board.GetBoard()[4] == game.Board.GetBoard()[5] && game.Board.GetBoard()[3] != ' ' ||
               game.Board.GetBoard()[6] == game.Board.GetBoard()[7] && game.Board.GetBoard()[7] == game.Board.GetBoard()[8] && game.Board.GetBoard()[6] != ' ' ||


               game.Board.GetBoard()[0] == game.Board.GetBoard()[3] && game.Board.GetBoard()[3] == game.Board.GetBoard()[6] && game.Board.GetBoard()[0] != ' ' ||
               game.Board.GetBoard()[1] == game.Board.GetBoard()[4] && game.Board.GetBoard()[4] == game.Board.GetBoard()[7] && game.Board.GetBoard()[1] != ' ' ||
               game.Board.GetBoard()[2] == game.Board.GetBoard()[5] && game.Board.GetBoard()[5] == game.Board.GetBoard()[8] && game.Board.GetBoard()[2] != ' ' ||


               game.Board.GetBoard()[0] == game.Board.GetBoard()[4] && game.Board.GetBoard()[4] == game.Board.GetBoard()[8] && game.Board.GetBoard()[0] != ' ' ||
               game.Board.GetBoard()[2] == game.Board.GetBoard()[4] && game.Board.GetBoard()[4] == game.Board.GetBoard()[6] && game.Board.GetBoard()[2] != ' '

                ) {


                if (game.Turn.PlayerTurn == game.Player1) {
                    Console.WriteLine("Congratulations " + Name + " you win the match!");
                    game.Winner = game.Player1.Name;
                } else {
                    Console.WriteLine("Congratulations " + Name + " you win the match!");
                    game.Winner = game.Player2.Name;
                }
            }


        }
    }
}