using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Algorithms.Sort;

namespace Algorithms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            rando();
        }
        Random rand = new Random();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Point relativePoint = new Point(Canvas.GetLeft(as1.Children[0]), Canvas.GetTop(as1.Children[0]));
            Point relativePoint1 = new Point(Canvas.GetLeft(as1.Children[1]), Canvas.GetTop(as1.Children[1]));
            //Refresh();
            var moveAnimX = new DoubleAnimation(Canvas.GetLeft(name2), relativePoint.X, new Duration(TimeSpan.FromSeconds(0.5)));
            var moveAnimY = new DoubleAnimation(Canvas.GetTop(name2), relativePoint.Y, new Duration(TimeSpan.FromSeconds(0.5)));
            var moveAnimX1 = new DoubleAnimation(Canvas.GetLeft(name1), relativePoint1.X, new Duration(TimeSpan.FromSeconds(0.5)));
            var moveAnimY1 = new DoubleAnimation(Canvas.GetTop(name1), relativePoint1.Y, new Duration(TimeSpan.FromSeconds(0.5)));
            name1.BeginAnimation(Canvas.LeftProperty, moveAnimX);
            name1.BeginAnimation(Canvas.TopProperty, moveAnimY);
            name2.BeginAnimation(Canvas.LeftProperty, moveAnimX1);
            name2.BeginAnimation(Canvas.TopProperty, moveAnimY1);
        }

        void rando()
        {
            if (as1 != null) { as1.Children.Clear(); }
            double countWidth = 0;
            int maxWidth = 1160;
            int maxHieght = 550;
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    double double_rand = Math.Round((rand.NextDouble() + rand.Next(1, maxHieght)), 1);
                    if (!array.Contains(double_rand))
                    {
                        array[i] = double_rand;
                        break;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Border border = new Border();
                border.Width = 40;
                border.Height = 40;
                border.Background = new SolidColorBrush(Colors.Black);
                border.CornerRadius = new CornerRadius(8);
                Canvas.SetLeft(border, countWidth);
                Canvas.SetBottom(border, 10);
                as1.Children.Add(border);
                countWidth = countWidth + 10;
            }
        }
    }
}
