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
                this.Hide();
                sort.ShowDialog();
                this.Show();
            }
        }


        public TextBlock numberTime = new TextBlock
        {
            Margin = new Thickness(790, 10, 350, 582),
            Text = "0"
        };

        public Slider sliderTime = new Slider
        {
            Minimum = 0,
            Maximum = 10,
            IsSnapToTickEnabled = true,
            Margin = new Thickness(568, 10, 411, 582),

        };

        public Button btnPause = new Button
        {
            Content = "Pause",
            Margin = new Thickness(850, 10, 250, 582),
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
                    isAnimation = true
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
                
                

                
                sliderTime.ValueChanged += SliderTime_ValueChanged;
                
                

                sort.btnSortLinkedList.Visibility = Visibility.Hidden;
                sort.btnSortLinkedList.Visibility = Visibility.Collapsed;
                sort.LinkedListTime.Visibility = Visibility.Hidden;
                sort.LinkedListTime.Visibility = Visibility.Collapsed; 
                sort.ArrayTime.Visibility = Visibility.Hidden;
                sort.ArrayTime.Visibility = Visibility.Collapsed;
                sort.btnSortArray.Content = "Sort";
                sort.grid1.Children.Add(sliderTime);
                sort.grid1.Children.Add(numberTime);
                sort.grid1.Children.Add(btnPause);
                this.Hide();
                sort.ShowDialog();
                this.Show();
            }
        }

        private void SliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTime.Text = (sliderTime.Value/10).ToString();
            Sort.numberTime = sliderTime.Value / 10;
        }
    }
}
