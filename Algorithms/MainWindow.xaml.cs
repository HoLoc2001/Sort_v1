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
            if (rbBubble.IsChecked == true|| rbQuick.IsChecked == true || rbHead.IsChecked == true)
            {
                Sort sort = new Sort();
                sort.checkBubbleSort = (bool)rbBubble.IsChecked;
                sort.checkQuickSort = (bool)rbQuick.IsChecked;
                sort.checkHeapSort = (bool)rbHead.IsChecked;
                
                this.Hide();
                sort.ShowDialog();
                this.Show();
                
            }
        }
    }
}
