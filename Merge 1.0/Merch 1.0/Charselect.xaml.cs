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

        private void Char_1(object sender, RoutedEventArgs e)
        {

        }

        private void Char_1_1(object sender, RoutedEventArgs e)
        {

        }

        private void Char_2(object sender, RoutedEventArgs e)
        {

        }

        private void Char_2_1(object sender, RoutedEventArgs e)
        {

        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
    }
}
