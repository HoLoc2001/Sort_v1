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

        public void Bubble_sort(Doublely_LinkedList Linked_List, Canvas canvas1)
        {
            int j = 0;
            Node current = null;
            bool Swapped = false;
            do
            {
                j = 0;
                current = Linked_List.head;
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

        public void Bubble_sort_animation(Doublely_LinkedList Linked_List, Canvas canvas1)
        {
            int j = 0;
            Node current = null;
            bool Swapped = false;
            do
            {
                j = 0;
                current = Linked_List.head;
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

        

        public void Quick_sort(Doublely_LinkedList Linked_List, Node head , Node last, Canvas canvas1)
        {
            if (Linked_List.head != null && last != Linked_List.head && last != Linked_List.head.next)
            {
                double pivot = Linked_List.head.data;
                Node i = last;
                Node j = head;
                double temp;
                for (; j != Linked_List.head; j = j.next)
                {
                    if (j.data <= pivot)
                    {
                        _ = (i == null) ? last : i.next;
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
                _ = (i == null) ? last : i.next;
                temp = i.data;
                i.data = head.data;
                head.data = temp;
                Quick_sort(Linked_List, i.prev, last, canvas1);
                Quick_sort(Linked_List, head, i.next, canvas1);
            }
        }
    }
}
