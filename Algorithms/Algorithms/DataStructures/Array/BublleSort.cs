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
    public class BublleSort
    {
        #region BublleSort
        public static void Bubble_sort(double[] arr, Canvas canvas1)
        {
            int lenght = arr.Length;
            int count = 1;
            bool Swapped;
            do
            {
                Swapped = false;
                for (int j = 0; j < lenght - count; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swapped = true;
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, arr[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, arr[j]);
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                count++;
            } while (Swapped);
        }

        public static void Bubble_sort_animation(double[] arr, Canvas canvas1)
        {
            int lenght = arr.Length;
            int count = 1;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght - count; j++)
                {
                    Swap_color.start_Swap_Color(canvas1, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (arr[j] > arr[j + 1])
                    {
                        Swap_color.sort_Swap_Color(canvas1, j);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, arr[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, arr[j]);
                        Swap(ref arr[j], ref arr[j + 1]);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    Swap_color.end_Swap_Color(canvas1, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                }
                count++;
            }
        }
        #endregion
    }
}
