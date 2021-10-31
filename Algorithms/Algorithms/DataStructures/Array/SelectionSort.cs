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
    public class SelectionSort
    {
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
                    }
                    else
                    { }
                }
                if (minIndex != i)
                {
                    Swap(ref arr[minIndex], ref arr[i]);
                }
            }
        }

        #endregion
    }
}
