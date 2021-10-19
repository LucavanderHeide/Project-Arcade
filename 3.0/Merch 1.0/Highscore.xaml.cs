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
    /// Interaction logic for Highscore.xaml
    /// </summary>
    public partial class Highscore : Window
    {
        public Highscore()
        {
            InitializeComponent();
        }
        
        private void Quitbtn(object sender, RoutedEventArgs e)
        {
            MainWindow start = new MainWindow();
            start.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
