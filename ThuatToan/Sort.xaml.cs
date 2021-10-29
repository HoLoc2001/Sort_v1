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
using ThuatToan.Data;

namespace ThuatToan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Sort
    {
        public delegate void EmptyDelegate();
        int Number;
        double[] array;
        double countWidth = 0;
        Random rand = new Random();
        double[] arrayClone;
        public bool checkBubbleSort = false;
        public bool checkQuickSort = false;
        public bool checkHeapSort = false;
        Thread t1;
        

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
            this.Dispatcher.Invoke(() =>
            {
                if (checkBubbleSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    Array_sort.Bubble_sort_animation(array, canvas1);
                    start.Stop();
                    ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                }
                else if (checkQuickSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    Array_sort.Quick_sort_animation(array, 0, array.Length - 1, canvas1);
                    start.Stop();
                    ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                }
            });
            
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
                    double double_rand = rand.NextDouble() + rand.Next(1, maxHieght);
                    if (!array.Contains(double_rand))
                    {
                        array[i] = Math.Round(double_rand, 1);
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

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSortLinkedList_Click(object sender, RoutedEventArgs e)
        {
            Doublely_LinkedList Linked_List = new Doublely_LinkedList();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Linked_List.addLast(Linked_List, array[i]);
            }
            if (checkBubbleSort)
            {
                
                if (checkBubbleSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    if ((bool)cbAnimation.IsChecked)
                    {
                        Linked_List.Bubble_sort_animation(canvas1);
                    }
                    else
                    {
                        Linked_List.Bubble_sort(canvas1);
                    }
                    start.Stop();
                    LinkedListTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                } 
            }else if (checkQuickSort)
            {
                Stopwatch start = new Stopwatch();
                start.Start();
                Node i = Linked_List.GetHeadNode(Linked_List);
                Node j = Linked_List.GetLastNode(Linked_List);
                //Linked_List.Quick_sort(Linked_List, i, j, canvas1);
                Linked_List.quickSort(Linked_List.GetHeadNode(Linked_List));
                start.Stop();
                LinkedListTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
            }
        }

        private void btnSortArray_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)cbAnimation.IsChecked)
            {
                if (t1 != null)
                {
                    t1.Abort();
                }
                t1 = new Thread(new ThreadStart(sort_array_animation));
                t1.Start();
            }
            else
            {
                if (checkBubbleSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    Array_sort.Bubble_sort(array, canvas1);
                    start.Stop();
                    ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                }
                else if (checkQuickSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    Array_sort.Quick_sort(array, 0, array.Length - 1, canvas1);
                    start.Stop();
                    ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                }
                else if (checkHeapSort)
                {
                    Stopwatch start = new Stopwatch();
                    start.Start();
                    Array_sort.Heap_sort(array, array.Length, canvas1);
                    start.Stop();
                    ArrayTime.Text = $"{start.Elapsed.Ticks * 100:#,###} nanoseconds";
                }
            }
        }
    }
}
