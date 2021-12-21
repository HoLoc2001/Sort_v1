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
            int writes = 0;
            for (int cycle_start = 0; cycle_start <= n - 2; cycle_start++)
            {
                double item = arr[cycle_start];
                int pos = cycle_start;
                for (int i = cycle_start + 1; i < n; i++)
                {
                    if (arr[i] < item)
                    {
                        pos++;
                    }
                }
                if (pos == cycle_start)
                    continue;
                while (item == arr[pos])
                    pos += 1;
                if (pos != cycle_start)
                {
                    double temp = item;
                    item = arr[pos];
                    arr[pos] = temp;
                    writes++;
                }
                while (pos != cycle_start)
                {
                    pos = cycle_start;
                    for (int i = cycle_start + 1; i < n; i++)
                        if (arr[i] < item)
                        {
                            pos += 1;
                        }
                            
                    while (item == arr[pos])
                    {
                        pos += 1;
                    }
                        
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
