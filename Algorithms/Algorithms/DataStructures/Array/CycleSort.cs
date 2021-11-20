using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Array
{
    class CycleSort
    {
        public static void Cycle_sort(double[] arr, int n)
        {
            // count number of memory writes
            int writes = 0;

            // traverse array elements and
            // put it to on the right place
            for (int cycle_start = 0; cycle_start <= n - 2; cycle_start++)
            {
                // initialize item as starting point
                double item = arr[cycle_start];

                // Find position where we put the item.
                // We basically count all smaller elements
                // on right side of item.
                int pos = cycle_start;
                for (int i = cycle_start + 1; i < n; i++)
                    if (arr[i] < item)
                        pos++;

                // If item is already in correct position
                if (pos == cycle_start)
                    continue;

                // ignore all duplicate elements
                while (item == arr[pos])
                    pos += 1;

                // put the item to it's right position
                if (pos != cycle_start)
                {
                    double temp = item;
                    item = arr[pos];
                    arr[pos] = temp;
                    writes++;
                }

                // Rotate rest of the cycle
                while (pos != cycle_start)
                {
                    pos = cycle_start;

                    // Find position where we put the element
                    for (int i = cycle_start + 1; i < n; i++)
                        if (arr[i] < item)
                            pos += 1;

                    // ignore all duplicate elements
                    while (item == arr[pos])
                        pos += 1;

                    // put the item to it's right position
                    if (item != arr[pos])
                    {
                        double temp = item;
                        item = arr[pos];
                        arr[pos] = temp;
                        writes++;
                    }
                }
            }
        }
    }
}
