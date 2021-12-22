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

namespace PlayerMovement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        
        

        private void BtnSpelen(object sender, RoutedEventArgs e)
        {
            Gamewindow game = new Gamewindow();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void BtnLeaderboard(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnQuit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
