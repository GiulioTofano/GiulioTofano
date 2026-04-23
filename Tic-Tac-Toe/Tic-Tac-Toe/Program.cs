using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe {
    internal class Program {
        static void Main(string[] args) {


            Game game = new Game();
            game.SetupGame(game.Player1, game.Player2);
            game.GameStart();


            switch (game.Player2.Name) {
                // PvIA
                case "IA":
                    break;

                // PvP
                default:

                    Console.WriteLine("\nType the name of the player who will start the game ::\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    String a = Console.ReadLine();
                    Console.ResetColor();
                    if (a == game.Player1.Name) {
                        game.Turn.PlayerTurn = game.Player1;
                    } else if (a == game.Player2.Name) {
                        game.Turn.PlayerTurn = game.Player2;
                    } else {
                        Console.WriteLine("I don't understand your choice, so i will choose randomly who will start the game");
                        Random random = new Random();
                        int randomNumber = random.Next(0, 2);
                        if (randomNumber == 0) {
                            game.Turn.PlayerTurn = game.Player1;
                        } else {
                            game.Turn.PlayerTurn = game.Player2;
                        }
                    }
                    Console.WriteLine("\nWe are officially into the game, so have fun and do you best!!  ");
                    game.Board.BuildBoard(game);

                    while (game.Winner == null) {

                        Console.Write("Name of the player's turn :: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(game.Turn.PlayerTurn.Name + "\n");
                        Console.ResetColor();

                        if (game.Turn.PlayerTurn == game.Player1) {
                            game.Player1.PlacePawn(game, Convert.ToInt16(Console.ReadLine()) - 1);
                            game.Turn.PlayerTurn = game.Player2;
                        } else {
                            game.Player2.PlacePawn(game, Convert.ToInt16(Console.ReadLine()) - 1);
                            game.Turn.PlayerTurn = game.Player1;

                        }
                        game.Board.BuildBoard(game);
                        

                    }




                    break;
            }



        }
    }
}
