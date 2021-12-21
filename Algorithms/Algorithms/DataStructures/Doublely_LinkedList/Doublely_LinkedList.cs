using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using static Algorithms.Sort;

namespace Algorithms.DataStructures.Doublely_LinkedList
{
    public class Node
    {
        public double data;
        public Node prev;
        public Node next;
        public Node(double d, Node p)
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


        public void clear()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Node nextNode = currentNode.next;
                currentNode.next = null;
                currentNode.prev = null;
                currentNode.data = 0;
                currentNode = nextNode;
            }
            head = tail = null;
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        int getIndex(Node node)
        {
            int i = 0;
            while (true)
            {
                if (node.prev == null)
                {
                    return i;
                }
                node = node.prev;
                i++;
            }
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
            if (Linked_List.head == null)
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
            if(n == 0)
            {
                return head;
            }
            for (int i = 0; i < n; i++)
            {
                if (node.next == null)
                {
                    return node;
                }
                node = node.next;
            }
            return node;
        }


        #region BublleSort
        public void Bubble_sort()
        {
            Node current = null;
            bool Swapped = true;
            while (Swapped) 
            {
                current = head;
                Swapped = false;
                while (current != null && current.next != null)
                {
                    if (current.data > current.next.data)
                    {
                        Swapped = true;
                        Sort.Swap(ref current.data, ref current.next.data);
                    }
                    current = current.next;
                }
            } 
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
                _quickSort(h, temp.next);
                _quickSort(temp.prev, t);
            }
        }
        public void QuickSort(Node head)
        {
            Node last = GetLastNode(head);

            _quickSort(last, head);
        }
        #endregion

        #region HeapSort
        public void Heap_sort(Node h, int n) //n = size
        {
            for (Node i = getNode(h, n / 2 - 1); i == head || i != null; i = i.prev)
            {
                heapify(n, i);
            }
            for (Node i = getNode(h, n - 1); i != h; i = i.prev)
            {
                Swap(ref head.data, ref i.data);
                heapify(getIndex(i), head);
            }
        }

        void heapify(int n, Node i)
        {
            Node largest = i;
            Node left = getNode(head, getIndex(i) * 2 + 1) == null ? getNode(head,n) : getNode(head, getIndex(i) * 2 + 1);
            Node right = left.next == null ? left : left.next;
            if (getIndex(left) < n && left.data > largest.data)
                largest = left;
            if (getIndex(right) < n && (double)right.data > largest.data && left != right)
                largest = right;
            if (largest != i)
            {
                Swap(ref i.data, ref largest.data);
                heapify(n, largest);
            }
        }

        #endregion

        #region SelectionSort
        public void Selection_sort()
        {
            Node i = head;
            Node j;
            while (i != null && i != null)
            {
                Node tmp = i;
                j = i.next;
                while (j != null && j != null)
                {
                    if (j.data < tmp.data)
                    {
                        tmp = j;
                    }
                    j = j.next;
                }
                if (tmp != i)
                {
                    Swap(ref tmp.data, ref i.data);
                }
                i = i.next;
            }
        }
        #endregion

        #region InsertionSort
        public void Insertion_sort()
        {
            Node i = head;
            Node j;
            while (i != null && i != null)
            {
                double key = i.data;
                j = i.prev;
                while (j != null && j.data > key)
                {
                    j.next.data = j.data;
                    j = j.prev;
                }
                j.next.data = key;
                i = i.next;
            }
        }
    
        #endregion

        


        #region CocktailSort
        public void Cocktail_sort()
        {
            Node currentHead = null;
            Node currentTail = null;
            bool Swapped = true;
            
            while (Swapped)
            {
                currentHead = head;
                currentTail = tail;
                Swapped = false;
                while (currentHead != null && currentHead.next != null)
                {
                    if (currentHead.data > currentHead.next.data)
                    {
                        Swapped = true;
                        Sort.Swap(ref currentHead.data, ref currentHead.next.data);
                    }
                    currentHead = currentHead.next;
                }
                if (Swapped == false)
                    break;
                Swapped = false;
                currentTail = currentTail.prev;
                while (currentTail != null && currentTail.prev != null)
                {
                    if (currentTail.data > currentTail.next.data)
                    {
                        Swapped = true;
                        Sort.Swap(ref currentTail.data, ref currentTail.next.data);
                    }
                    currentTail = currentTail.prev;
                }
                currentHead = currentHead.next;
            }
        }
        #endregion


     
    }


}
