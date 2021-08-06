using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Players
    {
        private static string player1;
        private static string player2;

        public static string Player1 { get => player1; set => player1 = value; }
        public static string Player2 { get => player2; set => player2 = value; }
    }
}
