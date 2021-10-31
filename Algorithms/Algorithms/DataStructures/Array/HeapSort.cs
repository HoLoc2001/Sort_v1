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
