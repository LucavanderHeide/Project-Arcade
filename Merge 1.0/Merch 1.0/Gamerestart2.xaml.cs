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
    /// Interaction logic for Gamerestart2.xaml
    /// </summary>
    public partial class Gamerestart2 : Window
    {
        public Gamerestart2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name_invoeren game = new Name_invoeren();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
    }
}
