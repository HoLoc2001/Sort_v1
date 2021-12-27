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
    class CocktailSort
    {
        public static void Cocktail_sort(double[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (isClose)
                    {
                        return;
                    }
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end--;
                for (int i = end - 1; i >= start; i--)
                {
                    if (isClose)
                    {
                        return;
                    }
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                start++;
            }
        }

        public static void Cocktail_sort_animation(double[] arr, Canvas canvas)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    Swap_color.start_Swap_Color(canvas, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (arr[i] > arr[i + 1])
                    {
                        Swap_color.sort_Swap_Color(canvas, i);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas.Children[i].SetValue(Rectangle.HeightProperty, arr[i + 1]);
                        canvas.Children[i + 1].SetValue(Rectangle.HeightProperty, arr[i]);
                        Swap(ref arr[i], ref arr[i + 1]);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        swapped = true;
                    }
                    Swap_color.end_Swap_Color(canvas, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                }
                if (swapped == false)
                    break;
                swapped = false;
                end--;
                for (int i = end - 1; i >= start; i--)
                {
                    Swap_color.start_Swap_Color(canvas, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (arr[i] > arr[i + 1])
                    {
                        Swap_color.sort_Swap_Color(canvas, i);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas.Children[i].SetValue(Rectangle.HeightProperty, arr[i + 1]);
                        canvas.Children[i + 1].SetValue(Rectangle.HeightProperty, arr[i]);
                        Swap(ref arr[i], ref arr[i + 1]);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        swapped = true;
                    }
                    Swap_color.end_Swap_Color(canvas, i);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                }
                start++;
            }
        }
    }
}
