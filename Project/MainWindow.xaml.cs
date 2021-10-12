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

namespace Project
{    
    public partial class MainWindow : Window
    {
        private object paintCanvas;
        private object bonusPoints;
        private object currentPosition;
        private int headSize;

        public MainWindow()
        {
            InitializeComponent();
        }               

        public Window1() 
        {
            // Initiëren wortel
            for (int n = 0; n < 10; n++)
            {
                paintBonus(n);
            }
        }
        private void paintBonus(int index)
        {
            Point bonusPoint = new Point();

            Ellipse newEllipse = new Ellipse();

            Canvas.SetTop(newEllipse, bonusPoint.Y);
            Canvas.SetLeft(newEllipse, bonusPoint.X);
            object p1 = paintCanvas.Children.Insert(index, newEllipse);
            object p = bonusPoints.Insert(index, bonusPoint);

            // Dit gebeurt er wanneer je de wortel opeet, klopt nog niks van.
            int n = 0;
            foreach (Point point in bonusPoints)
            {

                if ((Math.Abs(point.X - currentPosition.X) < headSize) &&
                    (Math.Abs(point.Y - currentPosition.Y) < headSize))
                {
                    speed += 10;

                    // Wanneer de wortel wordt opgepakt, verdwijnt het
                    object p2 = bonusPoints.RemoveAt(n);
                    object p3 = paintCanvas.Children.RemoveAt(n);
                    paintBonus(n);
                    break;
                }
                n++;
            }
        }
    }
    private void generateFood() 
    {
        int maxXpos = pbCanvas.Size.Width / Settings.Width;
        int maxYpos = pbCanvas.Size.Height / Settings.Height;
        Random rnd = new Random();


    }


}
