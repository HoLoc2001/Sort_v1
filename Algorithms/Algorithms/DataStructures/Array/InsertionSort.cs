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
                    j--;
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
                if (isClose)
                {
                    return;
                }
                double key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    if (isClose)
                    {
                        return;
                    }
                    Swap_color.sort_Swap_Color(canvas, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    canvas.Children[j].SetValue(Rectangle.HeightProperty, key);
                    canvas.Children[j + 1].SetValue(Rectangle.HeightProperty, arr[j]);
                    arr[j + 1] = arr[j];
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    Swap_color.end_Swap_Color(canvas, j);
                    j--;
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                }
                canvas.Children[j + 1].SetValue(Rectangle.HeightProperty, key);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                arr[j + 1] = key;
            }
        }
    }
}
