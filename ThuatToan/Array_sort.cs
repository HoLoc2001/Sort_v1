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
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;
using static ThuatToan.Sort;

namespace ThuatToan
{
    public class Array_sort
    {
        public static void Bubble_sort(double[] array, Canvas canvas1)
        {

            int lenght = array.Length;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght - 1; j++)
                {
                    //Swap_color.start_Swap_Color(canvas1, j);
                    //Sort.Refresh();
                    //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (array[j] > array[j + 1])
                    {
                        //Swap_color.sort_Swap_Color(canvas1, j);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, array[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, array[j]);
                        Sort.Swap<double>(ref array[j], ref array[j + 1]);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    //Swap_color.end_Swap_Color(canvas1, j);
                    //Sort.Refresh();
                    //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                }
            }
        }

        public static void Quick_sort(double[] array, int left, int right, Canvas canvas1)//left: diem dau, right: diem cuoi
        {
            if (left <= right)
            {
                double pivot;
                if ((array[left] >= array[right] || array[(left + right) / 2] >= array[right]) && (array[right] >= array[(left + right) / 2] || array[right] >= array[left]))
                {
                    pivot = array[right];
                }
                else if ((array[right] >= array[left] || array[(left + right) / 2] >= array[left]) && (array[left] >= array[(left + right) / 2] || array[left] >= array[right]))
                {
                    pivot = array[left];
                }
                else
                {
                    pivot = array[(left + right) / 2];
                }

                int l = left;
                int r = right;

                while (l <= r)
                {
                    while (array[l] < pivot)
                        l++;
                    while (array[r] > pivot)
                        r--;

                    if (l <= r)
                    {
                        //Swap_color.sort_Swap_Color(canvas1, l, r);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[l].SetValue(Rectangle.HeightProperty, array[r]);
                        canvas1.Children[r].SetValue(Rectangle.HeightProperty, array[l]);
                        Sort.Swap<double>(ref array[l], ref array[r]);
                        //Swap_color.end_Swap_Color(canvas1, l, r);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        l++;
                        r--;
                    }
                    
                }

                if (left < r) Quick_sort(array, left, r, canvas1);
                if (right > l) Quick_sort(array, l, right, canvas1);
            }
        }
    }
}
