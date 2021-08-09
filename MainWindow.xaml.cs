using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblPlayer1.Content = Players.Player1;
            lblPlayer2.Content = Players.Player2;
        }

        public static bool turn = true;
        public static string winner = "";
        public static int point1 = 0;
        public static int point2 = 0;

        private void UserClick(Button btn)
        {
            if (btn.IsEnabled)
            {
                btn.Content = (turn) ? "X" : "O";

                if (btn.Name == "btn1_1")
                    Cells.C1_1 = (turn) ? "X" : "O";
                else if (btn.Name == "btn1_2")
                    Cells.C1_2 = (turn) ? "X" : "O";
                else if (btn.Name == "btn1_3")
                    Cells.C1_3 = (turn) ? "X" : "O";
                else if (btn.Name == "btn2_1")
                    Cells.C2_1 = (turn) ? "X" : "O";
                else if (btn.Name == "btn2_2")
                    Cells.C2_2 = (turn) ? "X" : "O";
                else if (btn.Name == "btn2_3")
                    Cells.C2_3 = (turn) ? "X" : "O";
                else if (btn.Name == "btn3_1")
                    Cells.C3_1 = (turn) ? "X" : "O";
                else if (btn.Name == "btn3_2")
                    Cells.C3_2 = (turn) ? "X" : "O";
                else if (btn.Name == "btn3_3")
                    Cells.C3_3 = (turn) ? "X" : "O";

                turn = !turn;
                btn.IsEnabled = false;

                //Game();
            }
            Game();
        }

        private void ResetTable()
        {
            Cells.C1_1 = "";
            Cells.C1_2 = "";
            Cells.C1_3 = "";
            Cells.C2_1 = "";
            Cells.C2_2 = "";
            Cells.C2_3 = "";
            Cells.C3_1 = "";
            Cells.C3_2 = "";
            Cells.C3_3 = "";

            btn1_1.Content = "";
            btn1_2.Content = "";
            btn1_3.Content = "";
            btn2_1.Content = "";
            btn2_2.Content = "";
            btn2_3.Content = "";
            btn3_1.Content = "";
            btn3_2.Content = "";
            btn3_3.Content = "";

            btn1_1.IsEnabled = true;
            btn1_2.IsEnabled = true;
            btn1_3.IsEnabled = true;
            btn2_1.IsEnabled = true;
            btn2_2.IsEnabled = true;
            btn2_3.IsEnabled = true;
            btn3_1.IsEnabled = true;
            btn3_2.IsEnabled = true;
            btn3_3.IsEnabled = true;
        }

        private void Game()
        {
            bool win = false;

            #region Vertical Wins

            if (!btn1_1.IsEnabled && !btn1_2.IsEnabled && !btn1_3.IsEnabled)
            {
                if (Cells.C1_1 == Cells.C1_2 && Cells.C1_1 == Cells.C1_3)
                {
                    winner = (Cells.C1_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            else if (!btn2_1.IsEnabled && !btn2_2.IsEnabled && !btn2_3.IsEnabled)
            {
                if (Cells.C2_1 == Cells.C2_2 && Cells.C2_1 == Cells.C2_3)
                {
                    winner = (Cells.C2_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            else if (!btn3_1.IsEnabled && !btn3_2.IsEnabled && !btn3_3.IsEnabled)
            {
                if (Cells.C3_1 == Cells.C3_2 && Cells.C3_1 == Cells.C3_3)
                {
                    winner = (Cells.C3_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            #endregion

            #region Horizontal Wins

            if (!btn1_1.IsEnabled && !btn2_1.IsEnabled && !btn3_1.IsEnabled)
            {
                if (Cells.C1_1 == Cells.C2_1 && Cells.C1_1 == Cells.C3_1)
                {
                    winner = (Cells.C1_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            else if (!btn1_2.IsEnabled && !btn2_2.IsEnabled && !btn3_2.IsEnabled)
            {
                if (Cells.C1_2 == Cells.C2_2 && Cells.C1_2 == Cells.C3_2)
                {
                    winner = (Cells.C1_2 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            else if (!btn1_3.IsEnabled && !btn2_3.IsEnabled && !btn3_3.IsEnabled)
            {
                if (Cells.C1_3 == Cells.C2_3 && Cells.C1_3 == Cells.C3_3)
                {
                    winner = (Cells.C1_3 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            #endregion

            #region Cross Wins

            if (!btn1_1.IsEnabled && !btn2_2.IsEnabled && !btn3_3.IsEnabled)
            {
                if (Cells.C1_1 == Cells.C2_2 && Cells.C1_1 == Cells.C3_3)
                {
                    winner = (Cells.C1_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            if (!btn3_1.IsEnabled && !btn2_2.IsEnabled && !btn1_3.IsEnabled)
            {
                if (Cells.C3_1 == Cells.C2_2 && Cells.C3_1 == Cells.C1_3)
                {
                    winner = (Cells.C3_1 == "X") ? Players.Player1 : Players.Player2;
                    win = true;
                }
            }

            #endregion

            #region Check if game is finished

            //  if (Cells.C1_1.Length > 0 && Cells.C1_2.Length > 0 && Cells.C1_3.Length > 0 && Cells.C2_1.Length > 0 && Cells.C2_2.Length > 0 && Cells.C2_3.Length > 0 && Cells.C3_1.Length > 0 && Cells.C3_2.Length > 0 && Cells.C3_3.Length > 0)
            //  {
            //
            //      MessageBox.Show($"Game is finished! Winner is {winner}!");
            //  }

            if (win)
            {
                MessageBox.Show($"Tour is finished! Winner is {winner}!");
                ResetTable();

                if (winner == lblPlayer1.Content.ToString())
                {
                    point1++;
                }
                else if (winner == lblPlayer2.Content.ToString())
                {
                    point2++;
                }

                lblPoint1.Content = point1;
                lblPoint2.Content = point2;
            }

            #endregion
        }

        private void btn1_1_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn1_1);
        }

        private void btn1_2_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn1_2);
        }

        private void btn1_3_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn1_3);
        }

        private void btn2_1_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn2_1);
        }

        private void btn2_2_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn2_2);
        }

        private void btn2_3_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn2_3);
        }

        private void btn3_1_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn3_1);
        }

        private void btn3_2_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn3_2);
        }

        private void btn3_3_Click(object sender, RoutedEventArgs e)
        {
            UserClick(btn3_3);
        }

        private void btnResetTheTable_Click(object sender, RoutedEventArgs e)
        {
            ResetTable();
        }

        private void btnFinishTheGame_Click(object sender, RoutedEventArgs e)
        {
            string trueWinner = "";

            if (point1 > point2)
                trueWinner = Players.Player1;
            else if (point2 > point1)
                trueWinner = Players.Player2;
            else if (point1 == point2)
                trueWinner = "No one";

            ResetTable();
            point1 = 0;
            point2 = 0;
            lblPoint1.Content = point1;
            lblPoint2.Content = point2;

            MessageBox.Show($"GAME OVER\n{trueWinner} wins the game!");
        }
    }
}
