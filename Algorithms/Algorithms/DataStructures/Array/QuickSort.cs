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

        public static void Quick_sort_animation(double[] arr, int left, int right, Canvas canvas1)//left: diem dau, right: diem cuoi
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
                    Swap_color.Swap_Color_Blue(canvas1, l);
                    Swap_color.Swap_Color_Green(canvas1, r);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    while (arr[l] < pivot)
                    {
                        Swap_color.Swap_Color_Black(canvas1, l);
                        l++;
                        Swap_color.Swap_Color_Blue(canvas1, l);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    while (arr[r] > pivot)
                    {
                        Swap_color.Swap_Color_Black(canvas1, r);
                        r--;
                        Swap_color.Swap_Color_Green(canvas1, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    if (l <= r)
                    {
                        Swap_color.sort_Swap_Color(canvas1, l, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[l].SetValue(Rectangle.HeightProperty, arr[r]);
                        canvas1.Children[r].SetValue(Rectangle.HeightProperty, arr[l]);
                        Swap(ref arr[l], ref arr[r]);
                        Swap_color.end_Swap_Color(canvas1, l, r);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        l++;
                        r--;
                    }
                    else
                    {
                        Swap_color.Swap_Color_Black(canvas1, l);
                        Swap_color.Swap_Color_Black(canvas1, r);
                    }
                }
                if (left < r) Quick_sort_animation(arr, left, r, canvas1);
                if (right > l) Quick_sort_animation(arr, l, right, canvas1);
            }
        }
        #endregion
    }
}
