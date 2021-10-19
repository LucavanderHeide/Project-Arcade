﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Merch_1._0
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private ImageBrush PlayerBrush1 = new ImageBrush();
        private ImageBrush PlayerBrush2 = new ImageBrush();
        private ImageBrush Wortel = new ImageBrush();
        private bool MoveRight = false, MoveLeft = false, MoveUp = false, MoveDown = false;
        private bool MoveRight2 = false, MoveLeft2 = false, MoveUp2 = false, MoveDown2 = false;
        private DispatcherTimer GameTimer = new DispatcherTimer();        

        int speed1 = 7;        
        int speed2 = 7;
        int speedBoost1 = 30;
        int speedBoost2 = 30;
        Rect player1HitBox;
        Rect player2HitBox;


        public Window1()
        {
            InitializeComponent();

            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GameTimer.Tick += GameEngine;
            GameTimer.Start();

            Gamecanvas.Focus();
        }


        /// <summary>
        /// Hierin staan de bewegingen en het maken van de lijnen voor player 1 en 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameEngine(object sender, EventArgs e)
        {
            PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1S.png"));
            Player1.Fill = PlayerBrush1;

            PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2S.png"));
            Player2.Fill = PlayerBrush2;

            Wortel.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Wortel.png"));
            PowerUp.Fill = Wortel;

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

            //lijnen maken Player 1
            if (MoveRight)
            {
                Rectangle Lijn1 = new Rectangle
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Lijn1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }


            if (MoveLeft)
            {
                Ellipse Lijn1 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Lijn1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }

            if (MoveUp)
            {
                Ellipse Lijn1 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Lijn1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }

            if (MoveDown)
            {
                Ellipse Lijn1 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Lijn1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }


            //lijn maken player 2

            if (MoveDown2)
            {
                Ellipse Lijn2 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Lijn2.Height);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveUp2)
            {
                Ellipse Lijn2 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Lijn2.Height);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveRight2)
            {
                Ellipse Lijn2 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Lijn2.Height);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveLeft2)
            {
                Ellipse Lijn2 = new Ellipse
                {
                    Tag = "Lijn",
                    Height = 20,
                    Width = 20,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Lijn2.Height);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            player1HitBox = new Rect(Canvas.GetLeft(Player1), Canvas.GetTop(Player1), Player1.Width, Player1.Height);
            player2HitBox = new Rect(Canvas.GetLeft(Player2), Canvas.GetTop(Player2), Player2.Width, Player2.Height);

            foreach (var x in Gamecanvas.Children.OfType<Rectangle>())
            {
                Rect hitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                if ((string)x.Tag == "wall")
                {
                    if (player1HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        GameOver("Player1 heeft gewonnen! Klik op 'OK' om opnieuw te spelen");

                    }
                    if (player2HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        GameOver("Player2 heeft gewonnen! Klik op 'OK' om opnieuw te spelen");
                    }
                }
                if ((string)x.Tag == "Wortel")
                {
                    if (player1HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        PowerUp1();
                        TimerPowerUp1End();
                    }
                    if (player2HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        PowerUp2();
                        TimerPowerUp2End();
                    }
                }
            }
        }
        //PowerUp voor player 1
        private void PowerUp1()
        {
            speed1 = speedBoost1;
        }

        private void TimerPowerUp1End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp1End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }
        private void PowerUp1End(object source, EventArgs e)
        {
            speed1 = 7;
        }


        //PowerUp voor player 2
        private void PowerUp2()
        {
            speed2 = speedBoost2;
        }

        private void TimerPowerUp2End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp2End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }
        private void PowerUp2End(object source, EventArgs e)
        {
            speed2 = 7;
        }



        /// <summary>
        /// Verandert status naar true als knop wordt ingedrukt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gamecanvas_KeyDown(object sender, KeyEventArgs e)
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
        /// Verandert status naar false als de toets wordt losgelaten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gamecanvas_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1
            if (e.Key == Key.A)
            {
                MoveLeft = false;
            }

            if (e.Key == Key.D)
            {
                MoveRight = false;
            }

            if (e.Key == Key.W)
            {
                MoveUp = false;
            }

            if (e.Key == Key.S)
            {
                MoveDown = false;
            }


            //player 2
            if (e.Key == Key.Left)
            {
                MoveLeft2 = false;
            }

            if (e.Key == Key.Right)
            {
                MoveRight2 = false;
            }

            if (e.Key == Key.Up)
            {
                MoveUp2 = false;
            }

            if (e.Key == Key.Down)
            {
                MoveDown2 = false;
            }
        }

        
        
        /// <summary>
        /// Via deze knop wordt het spel afgesloten en het start scherm opgestart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitGame(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow Start = new MainWindow();
            Start.Visibility = Visibility.Visible;
            
        }


        /// <summary>
        /// Via deze code wordt het speelveld opnieuw gestart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetGame(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window1 game = new Window1();
            game.Visibility = Visibility.Visible;
        }
        private void GameOver(string message)
        {
            MessageBox.Show(message, "Nijntje game");
            Application.Current.Shutdown();
            System.Windows.Forms.Application.Restart();
        }
    }
}
