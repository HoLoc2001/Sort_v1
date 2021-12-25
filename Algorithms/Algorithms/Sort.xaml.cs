using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;
using Algorithms.DataStructures;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using Algorithms.DataStructures.Array;
using Algorithms.DataStructures.Doublely_LinkedList;

namespace Algorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Sort
    {
        public delegate void EmptyDelegate();
        public static double numberTime = 0;
        int Number;
        double[] array;
        double countWidth = 0;
        Random rand = new Random();
        double[] arrayClone;
        public bool checkBubbleSort = false;
        public bool checkQuickSort = false;
        public bool checkHeapSort = false;
        public bool checkSelectionSort = false;
        public bool checkInsertionSort = false;
        public bool checkCocktailSort = false;
        public bool isAnimation = false;
        Doublely_LinkedList Linked_List = new Doublely_LinkedList();

        public Sort()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            random();
        }

        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NumberTextBox.Text != " " && !string.IsNullOrEmpty(NumberTextBox.Text) && double.TryParse(NumberTextBox.Text, out double b)) { sliderNumber.Value = Convert.ToDouble(NumberTextBox.Text); }
        }

        void sort_array_animation()
        {
            if (checkBubbleSort)
            {
                Stopwatch start = new Stopwatch();
                start.Start();
                DataStructures.Array.BublleSort.Bubble_sort_animation(array, canvas1);
                start.Stop();
                ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
            }
            else if (checkQuickSort)
            {
                Stopwatch start = new Stopwatch();
                start.Start();
                DataStructures.Array.QuickSort.Quick_sort_animation(array, 0, array.Length - 1, canvas1);
                start.Stop();
                ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
            }
        }

        void random()
        {
            if (canvas1 != null) { canvas1.Children.Clear(); }
            countWidth = 0;
            int maxWidth = 1160;
            int maxHieght = 550;
            array = new double[Number];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    double double_rand = Math.Round((rand.NextDouble() + rand.Next(1, maxHieght)), 1);
                    if (!array.Contains(double_rand))
                    {
                        array[i] = double_rand;
                        break;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Rectangle rtgNext = new Rectangle();
                rtgNext.Width = maxWidth / (double)Number;
                rtgNext.Height = array[i];
                rtgNext.Fill = new SolidColorBrush(Colors.Black);
                Canvas.SetLeft(rtgNext, countWidth);
                Canvas.SetBottom(rtgNext, 0);
                canvas1.Children.Add(rtgNext);
                countWidth = countWidth + (maxWidth / (double)Number);
            }
            arrayClone = (double[])array.Clone();
        }

        private void sliderNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Number = Convert.ToInt32(sliderNumber.Value);
            random();
        }
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            array = (double[])arrayClone.Clone();
            if (canvas1 != null) { canvas1.Children.Clear(); }
            countWidth = 0;
            int maxWidth = 1160;
            for (int i = 0; i < array.Length; i++)
            {
                Rectangle rtgNext = new Rectangle();
                rtgNext.Width = maxWidth / (double)Number;
                rtgNext.Height = array[i];
                rtgNext.Fill = new SolidColorBrush(Colors.Black);
                Canvas.SetLeft(rtgNext, countWidth);
                Canvas.SetBottom(rtgNext, 0);
                canvas1.Children.Add(rtgNext);
                countWidth = countWidth + (maxWidth / (double)Number);
            }
        }

        public static void Refresh()
        {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Background, new EmptyDelegate(delegate { }));
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private void btnSortLinkedList_Click(object sender, RoutedEventArgs e)
        {
            Linked_List.clear();
            int length = array.Length, i = 0;
            for (int j = 0; j < length; j++)
            {
                Linked_List.addLast(Linked_List, array[j]);
            }
            Stopwatch start = new Stopwatch();
            
            if (checkBubbleSort)
            {
                start.Start();
                Linked_List.Bubble_sort();
                start.Stop();
            }
            else if (checkQuickSort)
            {
                start.Start();
                Linked_List.QuickSort(Linked_List.GetHeadNode(Linked_List));
                start.Stop();
            }
            else if (checkHeapSort)
            {
                start.Start();
                Linked_List.Heap_sort(Linked_List.GetHeadNode(Linked_List), length);
                start.Stop();
            }
            else if (checkSelectionSort)
            {
                start.Start();
                Linked_List.Selection_sort();
                start.Stop();
            }
            else if (checkInsertionSort)
            {
                start.Start();
                Linked_List.Insertion_sort();
                start.Stop();
            }
            else if (checkCocktailSort)
            {
                start.Start();
                Linked_List.Cocktail_sort();
                start.Stop();
            }

            Node node = Linked_List.GetHeadNode(Linked_List);
            while (node != null && node != null)
            {
                canvas1.Children[i].SetValue(Rectangle.HeightProperty, node.data);
                node = node.next;
                i++;
            }
            LinkedListTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
        }

        private void btnSortArray_Click(object sender, RoutedEventArgs e)
        {
            if (!isAnimation)
            {
                Stopwatch start = new Stopwatch();
                if (checkBubbleSort)
                {
                    start.Start();
                    BublleSort.Bubble_sort(array);
                    start.Stop();
                }
                else if (checkQuickSort)
                {
                    start.Start();
                    QuickSort.Quick_sort(array, 0, array.Length - 1);
                    start.Stop();
                }
                else if (checkHeapSort)
                {
                    start.Start();
                    HeapSort.Heap_sort(array, array.Length);
                    start.Stop();
                }
                else if (checkSelectionSort)
                {
                    start.Start();
                    SelectionSort.Selection_sort(array);
                    start.Stop();
                }
                else if (checkInsertionSort)
                {
                    start.Start();
                    InsertionSort.Insertion_sort(array);
                    start.Stop();
                }
                else if (checkCocktailSort)
                {
                    start.Start();
                    CocktailSort.Cocktail_sort(array);
                    start.Stop();
                }
                for (int i = 0; i < array.Length; i++)
                {
                    canvas1.Children[i].SetValue(Rectangle.HeightProperty, array[i]);
                }
                ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
            }
            else
            {
                if (checkBubbleSort)
                {
                    BublleSort.Bubble_sort_animation(array, canvas1);
                }else if (checkQuickSort)
                {
                    QuickSort.Quick_sort_animation(array, 0, array.Length - 1, canvas1);
                }
                else if (checkHeapSort)
                {
                    QuickSort.Quick_sort_animation(array, 0, array.Length - 1, canvas1);
                }
                else if (checkCocktailSort)
                {
                    CocktailSort.Cocktail_sort_animation(array, canvas1);
                }
                else if (checkInsertionSort)
                {
                    InsertionSort.Insertion_sort_animation(array, canvas1);
                }
                else if (checkSelectionSort)
                {
                    QuickSort.Quick_sort_animation(array, 0, array.Length - 1, canvas1);
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
