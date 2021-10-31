using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Array
{
    public class BublleSort
    {
        public static void Bubble_sort(double[] arr, Canvas canvas1)
        {
            int lenght = arr.Length;
            int count = 1;
            bool Swapped;
            do
            {
                Swapped = false;
                for (int j = 0; j < lenght - count; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swapped = true;
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, arr[j + 1]);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, arr[j]);
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                count++;
            } while (Swapped);
        }
    }
}
