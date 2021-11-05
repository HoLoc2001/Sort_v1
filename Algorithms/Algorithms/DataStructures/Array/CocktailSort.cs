using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Array
{
    class CocktailSort
    {
        public static void Cocktail_sort(double[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end--;
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                start++;
            }
        }
    }
}
