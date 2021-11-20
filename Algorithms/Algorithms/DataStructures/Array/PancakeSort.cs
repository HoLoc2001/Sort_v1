﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Array
{
    class PancakeSort
    {
        private static void flip(double[] arr, int i)
        {
            int start = 0;
            while (start < i)
            {
                double temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
                i--;
            }
        }
        private static int findMax(double[] arr, int n)
        {
            int mi, i;
            for (mi = 0, i = 0; i < n; ++i)
                if (arr[i] > arr[mi])
                    mi = i;

            return mi;
        }
        public static int Pancake_sort(double[] arr, int n)
        {
            int mi;
            for (int curr_size = n; curr_size > 1; curr_size--)
            {
                mi = findMax(arr, curr_size);
                if (mi != curr_size - 1)
                {
                    flip(arr, mi);
                    flip(arr, curr_size - 1);
                }
            }
            return 0;
        }
    }
}
