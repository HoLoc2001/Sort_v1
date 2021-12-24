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
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "asdasd";
                textBlock.Margin = new Thickness(868, 10, 111.667, 582);
                TextBlock textBlock1 = new TextBlock();
                textBlock1.Text = "asdasqwdqwdd";
                textBlock1.Margin = new Thickness(868, 10, 111.667, 582);

                sort.btnSortLinkedList.Visibility = Visibility.Hidden;
                sort.btnSortLinkedList.Visibility = Visibility.Collapsed;
                sort.LinkedListTime.Visibility = Visibility.Hidden;
                sort.LinkedListTime.Visibility = Visibility.Collapsed; 
                sort.ArrayTime.Visibility = Visibility.Hidden;
                sort.ArrayTime.Visibility = Visibility.Collapsed;
                sort.btnSortArray.Content = "Sort";
                sort.grid1.Children.Add(textBlock); 
                sort.grid1.Children.Add(textBlock1);

                this.Hide();
                sort.ShowDialog();
                this.Show();
            }
        }
    }
}
