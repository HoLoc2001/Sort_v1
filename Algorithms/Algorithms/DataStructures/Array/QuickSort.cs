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
    public class QuickSort
    {
        #region QuickSort
        public static void Quick_sort(double[] arr, int left, int right)//left: diem dau, right: diem cuoi
        {
            if (left <= right)
            {
                double pivot;
                if ((arr[left] >= arr[right] || arr[(left + right) / 2] >= arr[right]) && (arr[right] >= arr[(left + right) / 2] || arr[right] >= arr[left]))
                {
                    pivot = arr[right];
                }
                else if ((arr[right] >= arr[left] || arr[(left + right) / 2] >= arr[left]) && (arr[left] >= arr[(left + right) / 2] || arr[left] >= arr[right]))
                {
                    pivot = arr[left];
                }
                else
                {
                    pivot = arr[(left + right) / 2];
                }
                int l = left;
                int r = right;

                while (l <= r)
                {
                    while (arr[l] < pivot)
                    {
                        l++;
                    }
                    while (arr[r] > pivot)
                    {
                        r--;
                    }
                    if (l <= r)
                    {
                        Swap(ref arr[l], ref arr[r]);
                        l++;
                        r--;
                    }
                }
                if (left < r) Quick_sort(arr, left, r);
                if (right > l) Quick_sort(arr, l, right);
            }
        }

        public static void Quick_sort_animation(double[] arr, int left, int right, Canvas canvas)//left: diem dau, right: diem cuoi
        {
            if (isClose)
            {
                return;
            }
            if (left <= right)
            {
                double pivot;
                if ((arr[left] >= arr[right] || arr[(left + right) / 2] >= arr[right]) && (arr[right] >= arr[(left + right) / 2] || arr[right] >= arr[left]))
                {
                    pivot = arr[right];
                }
                else if ((arr[right] >= arr[left] || arr[(left + right) / 2] >= arr[left]) && (arr[left] >= arr[(left + right) / 2] || arr[left] >= arr[right]))
                {
                    pivot = arr[left];
                }
                else
                {
                    pivot = arr[(left + right) / 2];
                }
                int l = left;
                int r = right;

                while (l <= r)
                {
                    if (isClose)
                    {
                        return;
                    }
                    Swap_color.Swap_Color_Blue(canvas, l);
                    Swap_color.Swap_Color_Green(canvas, r);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    while (arr[l] < pivot)
                    {
                        if (isClose)
                        {
                            return;
                        }
                        Swap_color.Swap_Color_Black(canvas, l);
                        l++;
                        Swap_color.Swap_Color_Blue(canvas, l);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    while (arr[r] > pivot)
                    {
                        if (isClose)
                        {
                            return;
                        }
                        Swap_color.Swap_Color_Black(canvas, r);
                        r--;
                        Swap_color.Swap_Color_Green(canvas, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    if (l <= r)
                    {
                        if (isClose)
                        {
                            return;
                        }
                        Swap_color.sort_Swap_Color(canvas, l, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas.Children[l].SetValue(Rectangle.HeightProperty, arr[r]);
                        canvas.Children[r].SetValue(Rectangle.HeightProperty, arr[l]);
                        Swap(ref arr[l], ref arr[r]);
                        Swap_color.end_Swap_Color(canvas, l, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        l++;
                        r--;
                    }
                    else
                    {
                        Swap_color.Swap_Color_Black(canvas, l);
                        Swap_color.Swap_Color_Black(canvas, r);
                    }
                }
                if (left < r) Quick_sort_animation(arr, left, r, canvas);
                if (right > l) Quick_sort_animation(arr, l, right, canvas);
            }
        }
        #endregion
    }
}
