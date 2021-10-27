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

namespace Merch_1._0
{
    /// <summary>
    /// Interaction logic for Charselect.xaml
    /// </summary>
    public partial class Charselect : Window
    {
        public Charselect()
        {
            InitializeComponent();
        }

        public void Char_1(object sender, RoutedEventArgs e)
        {
            int Char1 = 1;
           
        }

        public void Char_1_1(object sender, RoutedEventArgs e)
        {
            int Char1_1 = 2;
        }

        public void Char_2(object sender, RoutedEventArgs e)
        {
            int Char_2 = 3;
        }

        public void Char_2_1(object sender, RoutedEventArgs e)
        {
            int Char_2 = 4;
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
    }
}
