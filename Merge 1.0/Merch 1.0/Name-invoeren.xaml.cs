using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static string speler1 = "";
        public static string speler2 = "";

        public Name_invoeren()
        {
            InitializeComponent();


        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 game = new Window1();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;

            speler1 = Speler1.Text;
            speler2 = Speler2.Text;

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow Start = new MainWindow();
            Start.Visibility = Visibility.Visible;
        }
    }
}