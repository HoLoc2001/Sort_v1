using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Shapes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;


namespace ThuatToan
{
    public class Swap_color
    {
        public static void start_Swap_Color(Canvas canvas, int j)
        {
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Blue));
            canvas.Children[j+1].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Blue));
        }
        public static void start_Swap_Color(Canvas canvas, int i, int j)
        {
            canvas.Children[i].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Blue));
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Blue));
        }
        public static void sort_Swap_Color(Canvas canvas, int j)
        {
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Red));
            canvas.Children[j + 1].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Red));
        }
        public static void sort_Swap_Color(Canvas canvas, int i,int j)
        {
            canvas.Children[i].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Red));
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Red));
        }
        public static void end_Swap_Color(Canvas canvas, int j)
        {
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Black));
            canvas.Children[j + 1].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Black));
        }
        public static void end_Swap_Color(Canvas canvas, int i,int j)
        {
            canvas.Children[i].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Black));
            canvas.Children[j].SetValue(System.Windows.Shapes.Rectangle.FillProperty, new SolidColorBrush(Colors.Black));
        }
    }
}
