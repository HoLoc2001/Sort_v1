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

namespace ThuatToan
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
            if (cbBubble.IsChecked == true|| cbQuick.IsChecked == true || cbHead.IsChecked == true)
            {
                Sort sort = new Sort();
                sort.checkBubbleSort = (bool)cbBubble.IsChecked;
                sort.checkQuickSort = (bool)cbQuick.IsChecked;
                sort.checkHeapSort = (bool)cbHead.IsChecked;
                if (sort.checkQuickSort)
                {
                    sort.btnSortLinkedList.Content = "Bubble sort";
                    sort.btnSort.Content = "Quick sort";
                }
                this.Hide();
                sort.ShowDialog();
                this.Show();
                
            }
        }
    }
}
