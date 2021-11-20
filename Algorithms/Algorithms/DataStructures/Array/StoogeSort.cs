using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Array
{
    class StoogeSort
    {
        public static void Stooge_sort(double[] arr, int l, int h)
        {
            if (l >= h)
                return;
            if (arr[l] > arr[h])
            {
                Swap(ref arr[l], ref arr[h]);
            }
            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;
                Stooge_sort(arr, l, h - t);
                Stooge_sort(arr, l + t, h);
                Stooge_sort(arr, l, h - t);
            }
        }
    }
}
