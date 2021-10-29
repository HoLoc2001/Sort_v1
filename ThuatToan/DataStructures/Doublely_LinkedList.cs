using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace ThuatToan.Data
{
    public class Node
    {
        public double data;
        public Node prev;
        public Node next;
        public Node (double d, Node p)
        {
            data = d;
            prev = p;
            next = null;
        }


    }
    public class Doublely_LinkedList
    {
        private int size;
        private Node head;
        private Node tail;

       
        public int Size()
        {
            return size;
        }
        public bool isEmpty()
        {
            return Size() == 0;
        }
        public Node GetLastNode(Doublely_LinkedList Linked_List)
        {
            Node temp = Linked_List.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        Node lastNode(Node node)
        {
            while (node.next != null)
                node = node.next;
            return node;
        }
        public Node GetHeadNode(Doublely_LinkedList Linked_List)
        {
            return Linked_List.head;
        }

        public void addLast(Doublely_LinkedList Linked_List, double element)
        {
            if (isEmpty())
            {
                Linked_List.head = Linked_List.tail = new Node(element, null);
            }
            else
            {
                Linked_List.tail.next = new Node(element, Linked_List.tail);
                Linked_List.tail = Linked_List.tail.next;
            }
            size++;
        }


        #region BublleSort
        public void Bubble_sort( Canvas canvas1)
        {
            int j = 0;
            Node current = null;
            bool Swapped = false;
            do
            {
                j = 0;
                current = head;
                Swapped = false;
                while (current != null && current.next != null)
                {
                    if (current.data > current.next.data)
                    {
                        Swapped = true;
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, current.next.data);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, current.data);
                        Sort.Swap<double>(ref current.data, ref current.next.data);
                    }
                    j++;
                    current = current.next;
                }
            } while (Swapped);
        }

        public void Bubble_sort_animation(Canvas canvas1)
        {
            int j = 0;
            Node current = null;
            bool Swapped = false;
            do
            {
                j = 0;
                current = head;
                Swapped = false;
                while (current != null && current.next != null)
                {
                    Swap_color.start_Swap_Color(canvas1, j);
                    Sort.Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (current.data > current.next.data)
                    {
                        Swapped = true;
                        Swap_color.sort_Swap_Color(canvas1, j);
                        Sort.Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, current.next.data);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, current.data);
                        Sort.Swap<double>(ref current.data, ref current.next.data);
                        Sort.Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    Swap_color.end_Swap_Color(canvas1, j);
                    Sort.Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    j++;
                    current = current.next;
                }
            } while (Swapped);
        }
        #endregion


        #region QuickSort
        Node partition(Node h, Node t)
        {
            // set pivot as h element  
            double pivot = h.data;

            Node i = t.prev;
            double temp;

            for (Node j = t; j != h; j = j.next)
            {
                if (j.data <= pivot)
                {
                    i = (i == null) ? t : i.next;
                    temp = i.data;
                    i.data = j.data;
                    j.data = temp;
                }
            }
            i = (i == null) ? t : i.next;
            temp = i.data;
            i.data = h.data;
            h.data = temp;
            return i;
        }

        void _quickSort(Node h, Node t)
        {
            if (h != null && t != h && t != h.next)
            {
                Node temp = partition(h, t);
                _quickSort(temp.prev, t);
                _quickSort(h ,temp.next);
            }
        }
        public void quickSort(Node node) // node = getLastNode
        {
            Node head = lastNode(node);

            _quickSort(head, node);
        }
        #endregion

        #region HeapSort


        #endregion
    }
}
