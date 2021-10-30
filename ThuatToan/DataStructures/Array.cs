using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Threading;
using static ThuatToan.Sort;

namespace ThuatToan
{
    public class Array_sort
    {
        #region BublleSort
        public static void Bubble_sort(double[] array, Canvas canvas1)
        {
            int lenght = array.Length;
            int count = 1;
            bool Swapped;
            do
            {
                Swapped = false;
                for (int j = 0; j < lenght - count; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swapped = true;
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, array[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, array[j]);
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
                count++;
            } while (Swapped);
        }
        
        public static void Bubble_sort_animation(double[] array, Canvas canvas1)
        {
            int lenght = array.Length;
            int count = 1;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght - count; j++)
                {
                    Swap_color.start_Swap_Color(canvas1, j);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (array[j] > array[j + 1])
                    {
                        Swap_color.sort_Swap_Color(canvas1, j);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, array[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, array[j]);
                        Swap(ref array[j], ref array[j + 1]);
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

        #region QuickSort
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
                    {
                        l++;
                    }
                    while (array[r] > pivot)
                    {
                        r--;
                    }
                    if (l <= r)
                    {
                        canvas1.Children[l].SetValue(Rectangle.HeightProperty, array[r]);
                        canvas1.Children[r].SetValue(Rectangle.HeightProperty, array[l]);
                        Swap(ref array[l], ref array[r]);
                        l++;
                        r--;
                    }
                }
                if (left < r) Quick_sort(array, left, r, canvas1);
                if (right > l) Quick_sort(array, l, right, canvas1);
            }
        }

        public static void Quick_sort_animation(double[] array, int left, int right, Canvas canvas1)//left: diem dau, right: diem cuoi
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
                    Swap_color.Swap_Color_Blue(canvas1, l);
                    Swap_color.Swap_Color_Green(canvas1, r);
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    while (array[l] < pivot)
                    {
                        Swap_color.Swap_Color_Black(canvas1, l);
                        l++;
                        Swap_color.Swap_Color_Blue(canvas1, l);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    while (array[r] > pivot)
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
                        canvas1.Children[l].SetValue(Rectangle.HeightProperty, array[r]);
                        canvas1.Children[r].SetValue(Rectangle.HeightProperty, array[l]);
                        Swap(ref array[l], ref array[r]);
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
                if (left < r) Quick_sort_animation(array, left, r, canvas1);
                if (right > l) Quick_sort_animation(array, l, right, canvas1);
            }
        }
        #endregion

        #region HeapSort
        public static void Heap_sort(double[] arr, int n, Canvas canvas1) //n la arr.lenght
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i, canvas1);
            }
                
            for (int i = n - 1; i >= 0; i--)
            {
                canvas1.Children[0].SetValue(Rectangle.HeightProperty, arr[i]);
                canvas1.Children[i].SetValue(Rectangle.HeightProperty, arr[0]);
                Swap(ref arr[0], ref arr[i]);
                heapify(arr, i, 0, canvas1);
            }
        }
        public static void heapify(double[] arr, int n, int i, Canvas canvas1)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                canvas1.Children[i].SetValue(Rectangle.HeightProperty, arr[largest]);
                canvas1.Children[largest].SetValue(Rectangle.HeightProperty, arr[i]);
                Swap(ref arr[i], ref arr[largest]);
                heapify(arr, n, largest, canvas1);
            }
        }
        #endregion
    }
}

