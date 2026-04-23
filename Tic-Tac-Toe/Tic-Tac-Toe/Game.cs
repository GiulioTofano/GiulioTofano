using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe {
    internal class Game {

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public String Winner { get; set; }

        public Turn Turn { get; set; }

        public Board Board { get; set; }

        public Game() {
            Player1 = new Player();
            Player2 = new Player();
            Board = new Board();
            Turn = new Turn();
            Winner = null;

        }

        public void SetupGame(Player player1, Player player2) {
            Console.Write("\n\nBefore you get into this beautifull game let me know some details so i can setup all." +
              "\nDo you want to play alone or with you friend? You can choose by digit ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1P");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2P\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            String numberOfPlayer;
            do {
                switch (numberOfPlayer = Console.ReadLine()) {
                    
                    case "1P":
                        Console.ResetColor();
                        Console.WriteLine("\nSo, you choose to play against me? Ok i'll accept the challenge." + 
                            "\nJust tell me your name choosen undead ::\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        player1.Name = Console.ReadLine();
                        player2.Name = "IA";
                        Console.ResetColor();
                        Console.WriteLine("\nWelcome ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(player1.Name);
                        Console.ResetColor();
                        Console.Write(" to my game, i hope you will have fun playing against me.");
                        break;
                    case "2P":
                        Console.ResetColor();
                        Console.WriteLine("\nSo,you are scared of me and choose to play with your friends. Understandable..." + 
                            " Tell me the name of the first player :: \n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        player1.Name = Console.ReadLine();
                        Console.ResetColor();
                        Console.WriteLine("\nNow tell me the name of the second player :: \n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        player2.Name = Console.ReadLine();  
                        Console.ResetColor();
                        Console.Write("\nWelcome ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(player1.Name);
                        Console.ResetColor();
                        Console.Write(" and ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(player2.Name);
                        Console.ResetColor();
                        Console.Write(" to my game, i hope you will have fun playing against each other.");
                        break;
                    default:
                        Console.WriteLine("I don't understand your choice, please choose between 1P and 2P");
                        break;
                }
            } while (numberOfPlayer != "1P" && numberOfPlayer != "2P");



        }
        public void GameStart() {
            Console.WriteLine(" Maybe you know it under the name Tris so the ruling are \nthe same (for now). " +
                "I will explain all, just continue reading.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nRULE NUMBER ONE");
            Console.ResetColor();
            Console.Write(" : The win condition is to place three consecutive pawn ( any direction is allowed ).");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nRULE NUMBER TWO");
            Console.ResetColor();
            Console.Write(" : A player cannot place a pawn upon another one.\n" );
            Console.Write("\nRemember that the number of the board positions starts from 1 to 9 and is organized form left to right, top to bottom.\n");
            Console.Write("Just like this :: \n\t\t\t1 2 3\n\t                4 5 6\n                        7 8 9\n");
            Turn.TurnNumber = 1;
            Turn.PlayerTurn = Player1;
        }
    }
}
