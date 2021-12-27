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
    public class SelectionSort
    {
        #region SelectionSort
        public static void Selection_sort(double[] arr)
        {
            int length = arr.Length;
            int i, j;
            for (i = 0; i < length; i++)
            {
                int minIndex = i;
                for (j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(ref arr[minIndex], ref arr[i]);
                }
            }
        }

        #endregion

        public static void Selection_sort_animation(double[] arr, Canvas canvas)
        {
            int length = arr.Length;
            int i, j;
            for (i = 0; i < length; i++)
            {
                int minIndex = i;
                for (j = i + 1; j < length; j++)
                {
                    if (isClose)
                    {
                        return;
                    }
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (isClose)
                {
                    return;
                }
                if (minIndex != i)
                {
                    Swap_color.start_Swap_Color(canvas, minIndex, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    Swap_color.sort_Swap_Color(canvas, minIndex, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    canvas.Children[minIndex].SetValue(Rectangle.HeightProperty, arr[i]);
                    canvas.Children[i].SetValue(Rectangle.HeightProperty, arr[minIndex]);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    Swap_color.end_Swap_Color(canvas, minIndex, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                    Swap(ref arr[minIndex], ref arr[i]);
                }
            }
        }
    }
}
