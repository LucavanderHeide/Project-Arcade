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

namespace Merch_1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Spelen_Click(object sender, RoutedEventArgs e)
        {
            Window1 game = new Window1();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
           
        }

        private void Menubtn(object sender, RoutedEventArgs e)
        {
            Highscore scoremenu = new Highscore();
            scoremenu.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void Quitapp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
