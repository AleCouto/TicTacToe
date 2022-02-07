using System;
namespace TicTacToe
{
    public class Views
    {
        public static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("|TicTacToe|");
            Console.WriteLine("|0 | 1 | 2|");
            Console.WriteLine("|3 | 4 | 5|");
            Console.WriteLine("|6 | 7 | 8|");
        }

        public static void DisplayPlayer1()
        {
            Console.Write("Player 1 enter positon for X: ");  
        }
        public static void DisplayPlayer2()
        {
            Console.Write("Player 2 enter positon for 0: ");
        }

        public static void DisplayWins()
        {
            Console.WriteLine("!!!You Wins!!!");
        }

        public static void DisplayTie()
        {
            Console.WriteLine("A tie!! Play Again");
        }

        public static void DisplayOccupied()
        {
            Console.WriteLine("Occupied Position!! try again!");
        }
    }
}
