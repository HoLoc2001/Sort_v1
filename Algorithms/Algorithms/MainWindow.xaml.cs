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
                rbInsertion.IsChecked == true || rbSelection.IsChecked == true || rbMerge.IsChecked == true ||
                rbCocktail.IsChecked == true || rbComb.IsChecked == true || rbStooge.IsChecked == true ||
                rbCycle.IsChecked == true || rbPancake.IsChecked == true || rbShell.IsChecked == true)
            {
                Sort sort = new Sort();
                sort.checkBubbleSort = (bool)rbBubble.IsChecked;
                sort.checkQuickSort = (bool)rbQuick.IsChecked;
                sort.checkHeapSort = (bool)rbHead.IsChecked;
                sort.checkInsertionSort = (bool)rbInsertion.IsChecked;
                sort.checkMergeSort = (bool)rbMerge.IsChecked;
                sort.checkSelectionSort = (bool)rbSelection.IsChecked;
                sort.checkCombSort = (bool)rbComb.IsChecked;
                sort.checkCocktailSort = (bool)rbCocktail.IsChecked;
                sort.checkStoogeSort = (bool)rbStooge.IsChecked;
                sort.checkCycleSort = (bool)rbCycle.IsChecked;
                sort.checkPancakeSort = (bool)rbPancake.IsChecked;
                sort.checkShellSort = (bool)rbShell.IsChecked;
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
                else if (sort.checkMergeSort)
                {
                    sort.txbAlgorithms.Text = "Merge Sort";
                }
                else if (sort.checkSelectionSort)
                {
                    sort.txbAlgorithms.Text = "Selection Sort";
                }
                else if (sort.checkCombSort)
                {
                    sort.txbAlgorithms.Text = "Comb Sort";
                }
                else if (sort.checkCocktailSort)
                {
                    sort.txbAlgorithms.Text = "Cocktail Sort";
                }
                else if (sort.checkStoogeSort)
                {
                    sort.txbAlgorithms.Text = "Stooge Sort";
                }
                else if (sort.checkCycleSort)
                {
                    sort.txbAlgorithms.Text = "Cycle Sort";
                }
                else if (sort.checkPancakeSort)
                {
                    sort.txbAlgorithms.Text = "Pancake Sort";
                }
                else if (sort.checkShellSort)
                {
                    sort.txbAlgorithms.Text = "Shell Sort";
                }
                this.Hide();
                sort.ShowDialog();
                this.Show();
            }
        }
    }
}
