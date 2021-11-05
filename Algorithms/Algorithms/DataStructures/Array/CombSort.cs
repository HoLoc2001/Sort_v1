using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Array
{
    class CombSort
    {
        private static int getNextGap(int gap)
        {
            gap = gap * 10 / 13;
            if (gap < 1)
                return 1;
            return gap;
        }
        public static void Comb_sort(double[] arr)
        {
            int n = arr.Length;
            int gap = n;
            bool swapped = true;
            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);
                swapped = false;
                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        Swap(ref arr[i], ref arr[i + gap]);
                        swapped = true;
                    }
                }
            }
        }
    }
}
