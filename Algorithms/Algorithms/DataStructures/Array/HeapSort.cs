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
    public class HeapSort
    {
        #region HeapSort
        public static void Heap_sort(double[] arr, int n) //n la arr.lenght
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                heapify(arr, i, 0);
            }

        }
        public static void heapify(double[] arr, int n, int i)
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
                Swap(ref arr[i], ref arr[largest]);
                heapify(arr, n, largest);
            }
        }
        #endregion

        public static void Heap_sort_animation(double[] arr, int n, Canvas canvas) //n la arr.lenght
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                if (isClose)
                {
                    return;
                }
                heapify_animation(arr, n, i, canvas);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (isClose)
                {
                    return;
                }
                Swap_color.start_Swap_Color(canvas, 0,i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap_color.sort_Swap_Color(canvas, 0, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                canvas.Children[0].SetValue(Rectangle.HeightProperty, arr[i]);
                canvas.Children[i].SetValue(Rectangle.HeightProperty, arr[0]);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap_color.end_Swap_Color(canvas, 0, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap(ref arr[0], ref arr[i]);
                heapify_animation(arr, i, 0, canvas);
            }

        }
        public static void heapify_animation(double[] arr, int n, int i, Canvas canvas)
        {
            if (isClose)
            {
                return;
            }
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                Swap_color.start_Swap_Color(canvas, largest, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap_color.sort_Swap_Color(canvas, largest, i);
                canvas.Children[largest].SetValue(Rectangle.HeightProperty, arr[i]);
                canvas.Children[i].SetValue(Rectangle.HeightProperty, arr[largest]);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap_color.end_Swap_Color(canvas, largest, i);
                Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(numberTime));
                Swap(ref arr[i], ref arr[largest]);
                heapify_animation(arr, n, largest, canvas);
            }
        }

    }
}
