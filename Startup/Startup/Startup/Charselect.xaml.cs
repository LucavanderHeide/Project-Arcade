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
    public partial class Charselect : Window
    {
        public Charselect()
        {
            InitializeComponent();
        }
        /// Namen voor spelers invullen
        public static void SpelerNaam()

        {
            string SpelerGeel;
            string SpelerRood;

            Console.Write("Naam Speler Geel: ");
            SpelerGeel = Console.ReadLine();

            Console.Write("Naam Speler Rood: ");
            SpelerRood = Console.ReadLine();
        }
        /// Logica voor knoppen character select, placeholder
        public void BtnNijntjeGeel(object sender, RoutedEventArgs e)
        {
            Startup.MainMenu objMainMenu = new Startup.MainMenu();
            Visibility = Visibility.Hidden;
            objMainMenu.Show();
        }
        public void BtnNijntjeRood(object sender, RoutedEventArgs e)
        {
            Startup.MainMenu objMainMenu = new Startup.MainMenu();
            Visibility = Visibility.Hidden;
            objMainMenu.Show();
        }
    }
}
