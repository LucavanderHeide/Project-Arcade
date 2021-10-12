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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_1_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateWortel()   
        {
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            // create a maximum X position int with half the size of the play area
            int maxYpos = pbCanvas.Size.Height / Settings.Height;
            // create a maximum Y position int with half the size of the play area
            Random rnd = new Random(); // create a new random class
            wortel = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
            // create a new food with a random x and y
        }

        private Circle wortel = new Circle();

        private void movePlayer()
        {
            // detect collision between Nijntje head and wortel
            if (Nijntje[0].X == wortel.X && Nijntje[0].Y == wortel.Y)
            {
                //if so we run the eat function
                eat();
            }
            else
            {
                Nijntje[i].X = Nijntje[i - 1].X;
                Nijntje[i].Y = Nijntje[i - 1].Y;
            }

            private void updateGraphics(object sender, PaintEventArgs e) 
            {
                // draw wortel
                canvas.FillEllipse(Brushes.Orange,
                                    new Rectangle(
                                        wortel.X * Settings.Width,
                                        wortel.Y * Settings.Height,
                                        Settings.Width, Settings.Height
                                        ));
            }

            private void startGame() 
            {
                generateWortel();
            }

            private void eat() 
            {
                speed + 5; 
                generateWortel();
            }
        }

    }
}
