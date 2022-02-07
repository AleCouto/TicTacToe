using System;


namespace TicTacToe
{
    public class Game
    {
        string[] Board = new string[9];
        int count = 0;
        public void InitGame()
        {
            Views.DisplayBoard();

            while (count < 8)
            {
                count += 2;

                //Player 1
                Views.DisplayPlayer1();
                int player1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (Board[player1] != null)
                {
                    Views.DisplayOccupied();
                }
                else
                {
                    Board[player1] = "X";
                }
                CheckWinner(1);

                //Player 2
                Views.DisplayPlayer2();
                int player2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (Board[player2] != null)
                {
                    Views.DisplayOccupied();
                }
                else
                {
                    Board[player2] = "O";
                }
                Board[player2] = "O";
                CheckWinner(2); 
            }
            Views.DisplayTie();
        }

        public void CheckWinner(int player)
        {
            string _player;
            if (player == 1)
            {
                _player = "X";
            }
            else
            {
                _player = "O";
            }
            
            //Row
            for (int row = 0; row < 8; row += 3)
            {
                if (_player == Board[row])
                {
                    if (Board[row] == Board[row + 1] && Board[row] == Board[row + 2])
                    {
                        Views.DisplayWins();                
                        Program.Start();
                    }
                }
            }

            //Column
            for (int col = 0; col < 3; col += 1)
            {
                if (_player == Board[col])
                {
                    if (Board[col] == Board[col + 3] && Board[col] == Board[col + 6])
                    {
                        Views.DisplayWins();    
                        Program.Start();
                    }
                }
            }

           //Diagonal
           if (_player == Board[0])
           {
               if (Board[0] == Board[4] && Board[0] == Board[8])
               {
                   Views.DisplayWins();
                   Program.Start();
               }
           }

            if (_player == Board[2])
            {
                if (Board[2] == Board[4] && Board[2] == Board[6])
                {
                    Views.DisplayWins();
                    Program.Start();
                }
            }
        }
    }
}
