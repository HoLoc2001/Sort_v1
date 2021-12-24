using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Array
{
    public class InsertionSort
    {
        #region InsertionSort
        public static void Insertion_sort(double[] arr)
        {
            int length = arr.Length;
            for (int i = 1; i < length; ++i)
            {
                double key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        #endregion

        public static void Insertion_sort_animation(double[] arr, Canvas canvas)
        {
            int length = arr.Length;
            for (int i = 1; i < length; ++i)
            {
                double key = arr[i];
                Swap_color.Swap_Color_Green(canvas, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(0.2));
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    Swap_color.sort_Swap_Color(canvas, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    canvas.Children[j].SetValue(Rectangle.HeightProperty, arr[j + 1]);
                    canvas.Children[j + 1].SetValue(Rectangle.HeightProperty, arr[j]);
                    arr[j + 1] = arr[j];
                    Swap_color.end_Swap_Color(canvas, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    j = j - 1;
                }
                Swap_color.Swap_Color_Black(canvas, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(0.2));
                canvas.Children[j + 1].SetValue(Rectangle.HeightProperty, key);
                arr[j + 1] = key;
                Swap_color.Swap_Color_Green(canvas, j +1);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(0.2));
            }
        }
    }
}
