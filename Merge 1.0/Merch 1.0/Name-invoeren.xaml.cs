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
    /// Interaction logic for Name_invoeren.xaml
    /// </summary>
    public partial class Name_invoeren : Window
    {
        public Name_invoeren()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 game = new Window1();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }
    }
}
