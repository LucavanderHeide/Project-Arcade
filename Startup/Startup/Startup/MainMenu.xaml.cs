using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Startup
{
    /// Interaction logic for MainMenu.xaml
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        /// Laat character select zien
        private void BtnSpelen(object sender, RoutedEventArgs e)
        {
            Startup.Charselect objCharselect = new Startup.Charselect();
            Visibility = Visibility.Hidden;
            objCharselect.Show();
        }
        /// Opent pagina met de highscores zien, moet eerst gemerged worden
        private void BtnLeaderboard(object sender, RoutedEventArgs e)
        {
            
        }
        /// Stopt het spel
        private void BtnQuit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
