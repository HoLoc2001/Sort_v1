using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Threading;
using static Algorithms.Sort;

namespace Algorithms
{
    public class Array_sort
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

        #region QuickSort
        public static void Quick_sort(double[] arr, int left, int right, Canvas canvas1)//left: diem dau, right: diem cuoi
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
                        canvas1.Children[l].SetValue(Rectangle.HeightProperty, arr[r]);
                        canvas1.Children[r].SetValue(Rectangle.HeightProperty, arr[l]);
                        Swap(ref arr[l], ref arr[r]);
                        l++;
                        r--;
                    }
                }
                if (left < r) Quick_sort(arr, left, r, canvas1);
                if (right > l) Quick_sort(arr, l, right, canvas1);
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

        #region HeapSort
        public static void Heap_sort(double[] arr, int n, Canvas canvas1) //n la arr.lenght
        {
            for(int i = n / 2 - 1; i >= 0; i--)
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
                    }else
                    { }
                }
                if (minIndex != i)
                {
                    Swap(ref arr[minIndex], ref arr[i]);
                }
            }
        }

        #endregion

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

        #region MergeSort
        public static void Merge_sort(double[] arr)
        {

        }
        #endregion
    }
}

