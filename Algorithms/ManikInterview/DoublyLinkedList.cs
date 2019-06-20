using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class DoublyLinkedListSample
    {
        public DoublyLinkedListSample()
        {
            Console.WriteLine("Hello");

            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

            linkedList.AddAtStart(15);            
            linkedList.AddAtEnd(45);
            linkedList.AddAtEnd(25);
            linkedList.AddAtStart(5);
            linkedList.AddAtEnd(35);
            linkedList.PrintAll();
            linkedList.Remove(5);
            linkedList.PrintAll();
            linkedList.Remove(35);
            linkedList.PrintAll();
            linkedList.Remove(45);
            linkedList.PrintAll();
            linkedList.Remove(15);
            linkedList.PrintAll();
            //linkedList.Remove(25);
            //linkedList.PrintAll();
            linkedList.AddAtStart(3);
            linkedList.PrintAll();

            Console.WriteLine("Done");
        }
    }

    public class DoublyLinkedList<T>
    {
        private Node<T> firstNode;
        private Node<T> current;
        private Node<T> lastNode;
        private int count;

        public DoublyLinkedList()
        {
            current = new Node<T>();
            firstNode = current;
            lastNode = current;
        }

        private void InitializeList(Node<T> node)
        {
            current = node;
            firstNode = current;
            lastNode = current;
            count++;
        }

        public Node<T> AddAtStart(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;

            if (count == 0)
            {
                InitializeList(node);
            }
            else
            {
                firstNode.Previous = node;
                node.Next = firstNode;
                firstNode = node;

                current = firstNode;
                count++;
            }

            return node;
        }

        public Node<T> AddAtEnd(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;

            if (count == 0)
            {
                InitializeList(node);
            }
            else
            {
                lastNode.Next = node;
                node.Previous = lastNode;
                lastNode = node;
                current = lastNode;
                count++;
            }
            return node;
        }

        public bool Remove(T value)
        {
            bool removed = false;

            if (firstNode.Value.Equals(value))
            {
                firstNode.Next.Previous = null;
                firstNode = firstNode.Next;
                count--;
            }
            else
            {
                Node<T> curr = firstNode;
                while(curr.Next != null)
                {
                    curr = curr.Next;
                    if (curr.Value.Equals(value))
                    {
                        if (curr.Next != null)
                        {
                            curr.Next.Previous = curr.Previous;
                            curr.Previous.Next = curr.Next;
                        }
                        else
                        {
                            curr.Previous.Next = null;
                        }
                        count--;
                    }
                }
            }

            return removed;
        }

        public void PrintAll()
        {
            Node<T> cur = firstNode;
            do
            {                
                Console.WriteLine(cur.Value);
                cur = cur.Next;
            } while (cur != null);

            Console.WriteLine("----------------------------");
        }
    }

    public class Node<T>
    {
        public Node<T> Previous { get; set; }
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        { }
    }
}
