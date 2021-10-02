using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace ThuatToan
{
    public class Node
    {
        public double data;
        public Node next;
        public Node(double d)
        {
            data = d;
            next = null;
        }
    }

    public class SinglyLinkedList
    {
        public Node head;
       
        public void InsertFront(SinglyLinkedList singlyList, double new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
        public Node GetLastNode(SinglyLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertLast(SinglyLinkedList singlyList, double new_data)
        {
            
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }
        public int Count (SinglyLinkedList singlyList)
        {
            int count = 0;
            Node current = singlyList.head;
            Node temp = null;
            while(current != null)
            {
                temp = current.next;
                current = temp;
                count++;
            }
            return count;
        }
        public void BubbleSort(SinglyLinkedList singlyList, Canvas canvas1)
        {
            int j = 0;
            Node current = null;
            bool Swapped = false;
            do
            {
                j = 0;
                current = singlyList.head;
                Swapped = false;
                while (current != null && current.next != null)
                {
                    //Swap_color.start_Swap_Color(canvas1, j);
                    //Sort.Refresh();
                    //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (current.data > current.next.data)
                    {
                        Swapped = true;
                        //Swap_color.sort_Swap_Color(canvas1, j);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, current.next.data);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, current.data);
                        //current.data = current.data + current.next.data;
                        //current.next.data = current.data - current.next.data;
                        //current.data = current.data - current.next.data;
                        Sort.Swap<double>(ref current.data, ref current.next.data);
                        //Sort.Refresh();
                        //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    //Swap_color.end_Swap_Color(canvas1, j);
                    //Sort.Refresh();
                    //Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    j++;
                    current = current.next;
                }
            } while (Swapped == true);
        }
    }
}
