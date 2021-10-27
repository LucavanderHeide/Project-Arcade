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
        private ImageBrush Wortel1 = new ImageBrush();
        private bool MoveRight = false, MoveLeft = false, MoveUp = false, MoveDown = false;
        private bool MoveRight2 = false, MoveLeft2 = false, MoveUp2 = false, MoveDown2 = false;
        private DispatcherTimer GameTimer = new DispatcherTimer();

        Rect player1HitBox;
        Rect player2HitBox;

        int p1score = 0;
        int p2score = 0;
        int speed1 = 5;        
        int speed2 = 5;
        int speedBoost1 = 10;
        int speedBoost2 = 10;
       public static int winp1 = 0;
       public static int winp2 = 0;

        

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

            p1scoretxt.Content = Name_invoeren.speler1;
            p2scoretxt.Content = Name_invoeren.speler2;


            PlayerBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player1S.png"));
            Player1.Fill = PlayerBrush1;

            PlayerBrush2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player2S.png"));
            Player2.Fill = PlayerBrush2;

            Wortel.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Wortel.png"));
            PowerUp.Fill = Wortel;

            Wortel1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Wortel.png"));
            PowerUp11.Fill = Wortel1;

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
                    Tag = "L1",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Player1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }


            if (MoveLeft)
            {
                Rectangle Lijn1 = new Rectangle
                {
                    Tag = "L1",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Player1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }

            if (MoveUp)
            {
                Rectangle Lijn1 = new Rectangle
                {
                    Tag = "L1",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red

                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Player1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }

            if (MoveDown)
            {
                Rectangle Lijn1 = new Rectangle
                {

                    Tag = "L1",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Red,
                    Stroke = Brushes.Red


                };

                Canvas.SetTop(Lijn1, Canvas.GetTop(Player1) - Player1.Height / 2);
                Canvas.SetLeft(Lijn1, Canvas.GetLeft(Player1) + Player1.Width / 2);
                Gamecanvas.Children.Add(Lijn1);
            }


            //lijn maken player 2

            if (MoveDown2)
            {
                Rectangle Lijn2 = new Rectangle
                {
                    Tag = "L2",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Player2.Height / 2);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveUp2)
            {
                Rectangle Lijn2 = new Rectangle
                {
                    Tag = "L2",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Player2.Height / 2);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveRight2)
            {
                Rectangle Lijn2 = new Rectangle
                {
                    Tag = "L2",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Player2.Height / 2);
                Canvas.SetLeft(Lijn2, Canvas.GetLeft(Player2) + Player2.Width / 2);
                Gamecanvas.Children.Add(Lijn2);
            }

            if (MoveLeft2)
            {
                Rectangle Lijn2 = new Rectangle
                {
                    Tag = "L2",
                    Height = 10,
                    Width = 10,
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Yellow

                };

                Canvas.SetTop(Lijn2, Canvas.GetTop(Player2) - Player2.Height / 2);
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
                        

                        MoveDown = false;
                        MoveUp = false;
                        MoveLeft = false;
                        MoveRight = false;

                        MoveDown2 = false;
                        MoveUp2 = false;
                        MoveLeft2 = false;
                        MoveRight2 = false;

                        winp2++;

                        Canvas.SetLeft(Player1, Canvas.GetLeft(resetrec));
                        Canvas.SetTop(Player1, Canvas.GetTop(resetrec));
                        Gamerestart reswin2 = new Gamerestart();
                        reswin2.Visibility = Visibility.Visible;
                        this.Visibility = Visibility.Hidden;
                    }
                    if (player2HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        

                        MoveDown2 = false;
                        MoveUp2 = false;
                        MoveLeft2 = false;
                        MoveRight2 = false;

                        MoveDown = false;
                        MoveUp = false;
                        MoveLeft = false;
                        MoveRight = false;

                        winp1++;

                        Canvas.SetLeft(Player2, Canvas.GetLeft(resetrec));
                        Canvas.SetTop(Player2, Canvas.GetTop(resetrec));
                        Gamerestart2 reswin1 = new Gamerestart2();
                        reswin1.Visibility = Visibility.Visible;
                        this.Visibility = Visibility.Hidden;


                        
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

                if ((string)x.Tag == "Wortel1")
                {
                    if (player1HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        PowerUp3();
                        TimerPowerUp3End();
                    }
                    if (player2HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        PowerUp4();
                        TimerPowerUp4End();
                    }
                }

                if ((string)x.Tag == "L2")
                {
                    if (player1HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {


                        MoveDown2 = false;
                        MoveUp2 = false;
                        MoveLeft2 = false;
                        MoveRight2 = false;

                        MoveDown = false;
                        MoveUp = false;
                        MoveLeft = false;
                        MoveRight = false;

                        winp2++;

                        Canvas.SetLeft(Player2, Canvas.GetLeft(resetrec));
                        Canvas.SetTop(Player2, Canvas.GetTop(resetrec));
                        Gamerestart2 reswin1 = new Gamerestart2();
                        if (!Application.Current.Windows.OfType<Gamerestart>().Any())
                        {
                            Gamerestart v2 = new Gamerestart();
                            v2.Visibility = Visibility.Visible;
                            this.Visibility = Visibility.Hidden;
                        }
                    }
                }

                if ((string)x.Tag == "L1")
                {

                    if (player2HitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {


                        MoveDown = false;
                        MoveUp = false;
                        MoveLeft = false;
                        MoveRight = false;

                        MoveDown2 = false;
                        MoveUp2 = false;
                        MoveLeft2 = false;
                        MoveRight2 = false;

                        winp1++;

                        Canvas.SetLeft(Player1, Canvas.GetLeft(resetrec));
                        Canvas.SetTop(Player1, Canvas.GetTop(resetrec));
                        Gamerestart reswin2 = new Gamerestart();
                        if (!Application.Current.Windows.OfType<Gamerestart2>().Any())
                        {
                            Gamerestart2 v2 = new Gamerestart2();
                            v2.Visibility = Visibility.Visible;
                            this.Visibility = Visibility.Hidden;
                        }
                    }
                }
            }






        }

        //PowerUp voor player 1
        private void PowerUp1()
        {
            speed1 = speedBoost1;
            Canvas.SetLeft(PowerUp, Canvas.GetLeft(resetrec));
            Canvas.SetTop(PowerUp, Canvas.GetTop(resetrec));
            PowerUp.Visibility = Visibility.Hidden;
        }

        private void PowerUp3()
        {
            speed1 = speedBoost1;
            Canvas.SetLeft(PowerUp11, Canvas.GetLeft(resetrec));
            Canvas.SetTop(PowerUp11, Canvas.GetTop(resetrec));
            PowerUp11.Visibility = Visibility.Hidden;
        }
        private void TimerPowerUp1End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp1End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }

        private void TimerPowerUp3End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp1End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }
        private void PowerUp1End(object source, EventArgs e)
        {
            speed1 = 5;
            
        }

        private void PowerUp4End(object source, EventArgs e)
        {
            speed1 = 5;

        }


        //PowerUp voor player 2
        private void PowerUp2()
        {
            speed2 = speedBoost2;
            Canvas.SetLeft(PowerUp, Canvas.GetLeft(resetrec));
            Canvas.SetTop(PowerUp, Canvas.GetTop(resetrec));
            PowerUp.Visibility = Visibility.Hidden;

        }

        private void PowerUp4()
        {
            speed2 = speedBoost2;
            Canvas.SetLeft(PowerUp11, Canvas.GetLeft(resetrec));
            Canvas.SetTop(PowerUp11, Canvas.GetTop(resetrec));
            PowerUp11.Visibility = Visibility.Hidden;

        }


        private void TimerPowerUp2End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp2End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }

        private void TimerPowerUp4End()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(PowerUp2End);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }
        private void PowerUp2End(object source, EventArgs e)
        {
            speed2 = 5;
        }

        private void PowerUp3End(object source, EventArgs e)
        {
            speed2 = 5;
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

       


        
    }
}
