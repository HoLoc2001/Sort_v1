using System;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Shapes;
using static Algorithms.Sort;

namespace Algorithms.Data
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

        Node GetLastNode(Node node)
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

        public Node getNode(Node node, int n)//node = GetHeadNode(), n = index
        {
            for (int i = 0; i < n; i++)
            {
                node = node.next;
            }
            return node;
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
                        Sort.Swap(ref current.data, ref current.next.data);
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
                    Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    if (current.data > current.next.data)
                    {
                        Swapped = true;
                        Swap_color.sort_Swap_Color(canvas1, j);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                        canvas1.Children[j].SetValue(Rectangle.HeightProperty, current.next.data);
                        canvas1.Children[j + 1].SetValue(Rectangle.HeightProperty, current.data);
                        Swap(ref current.data, ref current.next.data);
                        Refresh();
                        Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    }
                    Swap_color.end_Swap_Color(canvas1, j);
                    Refresh();
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
            double pivot = h.data;

            Node i = t.prev;

            for (Node j = t; j != h; j = j.next)
            {
                if (j.data <= pivot)
                {
                    i = (i == null) ? t : i.next;
                    Swap(ref i.data, ref j.data);
                }
            }
            i = (i == null) ? t : i.next;
            Swap(ref i.data, ref h.data);
            return i;
        }

        void _quickSort(Node h, Node t)
        {
            if (h != null && t != h && t != h.next)
            {
                Node temp = partition(h, t);
                _quickSort(h ,temp.next);
                _quickSort(temp.prev, t);
            }
        }
        public void quickSort(Node head) 
        {
            Node last = GetLastNode(head);

            _quickSort(last, head);
        }
        #endregion

        #region HeapSort
        public void Heap_sort(Node h, int n) //n = size
        {
            for (Node i = getNode(h ,n/2 -1); i != h; i = i.prev)
            {

            }
        }

        void heapify(Node n, Node i)
        {
            Node largest = i;
        }

        #endregion
    }
}
