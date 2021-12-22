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
using System.Windows.Threading;

namespace PlayerMovement
{
    /// <summary>
    /// Interaction logic for Gamewindow.xaml
    /// </summary>
    public partial class Gamewindow : Window
    {
        private ImageBrush PlayerBrush1 = new ImageBrush();
        private ImageBrush PlayerBrush2 = new ImageBrush();
        private bool MoveRight = false, MoveLeft = false, MoveUp = false, MoveDown = false;
        private bool MoveRight2 = false, MoveLeft2 = false, MoveUp2 = false, MoveDown2 = false;
        private DispatcherTimer GameTimer = new DispatcherTimer();
        int speed1 = 10;
        int speed2 = 10;

        public Gamewindow()
        {
            InitializeComponent();

            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GameTimer.Tick += GameEngine;
            GameTimer.Start();

            GameCanvas.Focus();
        }

        /// <summary>
        /// Hierin staan de bewegingen en de acties de charactar maakt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameEngine(object sender, EventArgs e)
        {

            PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1S.png"));
            Player1.Fill = PlayerBrush1;

            PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2S.png"));
            Player2.Fill = PlayerBrush2;


            //player 1
            if (MoveRight)
            {
                Canvas.SetLeft(Player1, Canvas.GetLeft(Player1) + speed1);
                PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1R.png"));
                Player1.Fill = PlayerBrush1;


            }

            if (MoveLeft)
            {
                Canvas.SetLeft(Player1, Canvas.GetLeft(Player1) - speed1);
                PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1L.png"));
                Player1.Fill = PlayerBrush1;

            }

            if (MoveUp)
            {
                Canvas.SetTop(Player1, Canvas.GetTop(Player1) - speed1);
                PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1N.png"));
                Player1.Fill = PlayerBrush1;
            }

            if (MoveDown)
            {
                Canvas.SetTop(Player1, Canvas.GetTop(Player1) + speed1);
                PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1S.png"));
                Player1.Fill = PlayerBrush1;
            }

            // player 2
            if (MoveRight2)
            {
                Canvas.SetLeft(Player2, Canvas.GetLeft(Player2) + speed2);
                PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2R.png"));
                Player2.Fill = PlayerBrush2;
            }

            if (MoveLeft2)
            {
                Canvas.SetLeft(Player2, Canvas.GetLeft(Player2) - speed2);
                PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2L.png"));
                Player2.Fill = PlayerBrush2;
            }

            if (MoveUp2)
            {
                Canvas.SetTop(Player2, Canvas.GetTop(Player2) - speed2);
                PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2N.png"));
                Player2.Fill = PlayerBrush2;
            }

            if (MoveDown2)
            {
                Canvas.SetTop(Player2, Canvas.GetTop(Player2) + speed2);
                PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2S.png"));
                Player2.Fill = PlayerBrush2;
            }
        }


        /// <summary>
        /// Hierin staat de besturing van de knoppen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            //player 1
            if (e.Key == Key.A)
            {
                MoveLeft = true;
            }

            if (e.Key == Key.D)
            {
                MoveRight = true;
            }

            if (e.Key == Key.W)
            {
                MoveUp = true;
            }

            if (e.Key == Key.S)
            {
                MoveDown = true;
            }


            //player 2
            if (e.Key == Key.Left)
            {
                MoveLeft2 = true;
            }

            if (e.Key == Key.Right)
            {
                MoveRight2 = true;
            }

            if (e.Key == Key.Up)
            {
                MoveUp2 = true;
            }

            if (e.Key == Key.Down)
            {
                MoveDown2 = true;
            }

        }

        /// <summary>
        /// Hierin staat de besturing van de knoppen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
    }
}
