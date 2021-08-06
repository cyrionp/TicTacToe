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
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtPlayer1.Clear();
            txtPlayer2.Clear();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (txtPlayer1.Text.Trim() != "" && txtPlayer2.Text.Trim() != "")
            {
                Players.Player1 = txtPlayer1.Text.Trim();
                Players.Player2 = txtPlayer2.Text.Trim();

                MainWindow main = new MainWindow();
                this.Close();
                main.Show();
            }
        }
    }
}
