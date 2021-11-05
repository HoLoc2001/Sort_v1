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
    public class MergeSort
    {
        static void merge(double[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            double[] L = new double[n1];
            double[] R = new double[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public static void Merge_Sort(double[] arr, int l, int r) //l = 0, r = length -1
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                Merge_Sort(arr, l, m);
                Merge_Sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }
    }
}
