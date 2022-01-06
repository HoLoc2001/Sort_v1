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
using System.Windows.Shapes;

namespace Algorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RoutedEventHandler ValueChanged { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Sort(object sender, RoutedEventArgs e)
        {
            if (rbBubble.IsChecked == true || rbQuick.IsChecked == true || rbHead.IsChecked == true || 
                rbInsertion.IsChecked == true || rbSelection.IsChecked == true || rbCocktail.IsChecked == true )
            {
                Sort sort = new Sort
                {
                    checkBubbleSort = (bool)rbBubble.IsChecked,
                    checkQuickSort = (bool)rbQuick.IsChecked,
                    checkHeapSort = (bool)rbHead.IsChecked,
                    checkInsertionSort = (bool)rbInsertion.IsChecked,
                    checkSelectionSort = (bool)rbSelection.IsChecked,
                    checkCocktailSort = (bool)rbCocktail.IsChecked
                };
                if (sort.checkBubbleSort)
                {
                    sort.txbAlgorithms.Text = "Bubble Sort";
                }
                else if (sort.checkQuickSort)
                {
                    sort.txbAlgorithms.Text = "Quick Sort";
                }
                else if (sort.checkHeapSort)
                {
                    sort.txbAlgorithms.Text = "Heap Sort";
                }
                else if (sort.checkInsertionSort)
                {
                    sort.txbAlgorithms.Text = "Insertion Sort";
                }
                else if (sort.checkSelectionSort)       
                {
                    sort.txbAlgorithms.Text = "Selection Sort";
                }
                else if (sort.checkCocktailSort)
                {
                    sort.txbAlgorithms.Text = "Cocktail Sort";
                }
                this.Close();
                sort.ShowDialog();
            }
        }


        public TextBlock numberTime = new TextBlock
        {
            Margin = new Thickness(710, 10, 400, 582),
            Text = "0 s"
        };

        public Slider sliderTime = new Slider
        {
            Minimum = 0,
            Maximum = 10,
            IsSnapToTickEnabled = true,
            Margin = new Thickness(550, 10, 480, 582),

        };

        public TextBlock Stable = new TextBlock
        {
            Margin = new Thickness(740, 10, 330, 582)
        };

        public TextBlock Time_Memory = new TextBlock
        {
            Margin = new Thickness(820, 15, 120, 572)
        };
        public TextBlock Time_Memory_Title = new TextBlock
        {
            Margin = new Thickness(820, 0, 120, 592),
            Text = "\t Time\t\t\tMemory"
            
        };

        private void btnAnimation_Click(object sender, RoutedEventArgs e)
        {
            if (rbBubble.IsChecked == true || rbQuick.IsChecked == true || rbHead.IsChecked == true ||
                rbInsertion.IsChecked == true || rbSelection.IsChecked == true || rbCocktail.IsChecked == true)
            {
                Sort sort = new Sort
                {
                    checkBubbleSort = (bool)rbBubble.IsChecked,
                    checkQuickSort = (bool)rbQuick.IsChecked,
                    checkHeapSort = (bool)rbHead.IsChecked,
                    checkInsertionSort = (bool)rbInsertion.IsChecked,
                    checkSelectionSort = (bool)rbSelection.IsChecked,
                    checkCocktailSort = (bool)rbCocktail.IsChecked,
                    isAnimation = true,
                };
                if (sort.checkBubbleSort)
                {
                    sort.txbAlgorithms.Text = "Bubble Sort";
                    Stable.Text = "Stable: Yes";
                    Time_Memory.Text = "O(n) / O(n^2) / O(n^2)  \t\t  O(1)";
                }
                else if (sort.checkQuickSort)
                {
                    sort.txbAlgorithms.Text = "Quick Sort";
                    Stable.Text = "Stable: No";
                    Time_Memory.Text = "O(nlogn) / O(nlogn) / O(n^2)\t O(logn)";
                }
                else if (sort.checkHeapSort)
                {
                    sort.txbAlgorithms.Text = "Heap Sort";
                    Stable.Text = "Stable: No";
                    Time_Memory.Text = "O(nlogn) / O(nlogn) / O(nlogn)  \t  O(1)";
                }
                else if (sort.checkInsertionSort)
                {
                    sort.txbAlgorithms.Text = "Insertion Sort";
                    Stable.Text = "Stable: Yes";
                    Time_Memory.Text = "O(n) / O(n^2) / O(n^2) \t\t  O(1)";
                }
                else if (sort.checkSelectionSort)
                {
                    sort.txbAlgorithms.Text = "Selection Sort";
                    Stable.Text = "Stable: No";
                    Time_Memory.Text = "O(n^2) / O(n^2) / O(n^2) \t\t  O(1)";
                }
                else if (sort.checkCocktailSort)
                {
                    sort.txbAlgorithms.Text = "Cocktail Sort";
                    Stable.Text = "Stable: Yes";
                    Time_Memory.Text = "O(n) / O(n^2) / O(n^2)  \t\t  O(1)";
                }


                sliderTime.ValueChanged += SliderTime_ValueChanged;
                Sort.isClose = false;
                

                sort.btnSortLinkedList.Visibility = Visibility.Hidden;
                sort.btnSortLinkedList.Visibility = Visibility.Collapsed;
                sort.LinkedListTime.Visibility = Visibility.Hidden;
                sort.LinkedListTime.Visibility = Visibility.Collapsed; 
                sort.ArrayTime.Visibility = Visibility.Hidden;
                sort.ArrayTime.Visibility = Visibility.Collapsed;
                sort.btnSortArray.Content = "Sort";
                sort.Title = "Sort Animation";
                sort.grid1.Children.Add(sliderTime);
                sort.grid1.Children.Add(numberTime);
                sort.grid1.Children.Add(Stable);
                sort.grid1.Children.Add(Time_Memory); 
                sort.grid1.Children.Add(Time_Memory_Title);
                this.Close();
                sort.ShowDialog();
            }
        }

        

        private void SliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTime.Text = (sliderTime.Value/10).ToString() + " s";
            Sort.numberTime = sliderTime.Value / 10;
        }
    }
}
