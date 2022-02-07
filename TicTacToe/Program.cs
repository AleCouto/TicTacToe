using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();  
        }

        public static void Start()
        {
            bool Turn = true;
            while (Turn)
            {
                Console.WriteLine("Start Game [Y] or [N]");
                string Start = Convert.ToString(Console.ReadLine());

                if (Start != null && (Start == "Y" || Start == "y"))
                {
                    var gm = new Game();
                    gm.InitGame();
                }
                if (Start != null && (Start == "N" || Start == "n"))
                {
                    Console.WriteLine("End Game");
                    Turn = false;
                }
                else
                {
                    Console.WriteLine("Command error!! Trye again.");
                    Turn = true;
                }
            }
        }
    }
}
