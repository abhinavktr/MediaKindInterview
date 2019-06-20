using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class CircularQueue
    {
        //https://codeinterview.io/XWHUOPMCAJ
        public CircularQueue()
        {
            Console.WriteLine("Hello");

            Queue<int> queue = new Queue<int>();
            //queue.PrintAllMessages();
            queue.Enqueue(1);
            queue.Enqueue(2);
            //queue.PrintAllMessages();
            queue.Dequeue();
            //queue.PrintAllMessages();
            queue.Enqueue(3);
            queue.Enqueue(4);
            //queue.PrintAllMessages();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            //queue.PrintAllMessages();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            //queue.PrintAllMessages();
            queue.Enqueue(14);
            //queue.PrintAllMessages();
            queue.Enqueue(15);
            queue.Enqueue(16);
            queue.Enqueue(17);
            queue.Enqueue(18);
            queue.Enqueue(19);
            queue.Enqueue(20);
            queue.Enqueue(21);
            queue.Enqueue(22);
            queue.Enqueue(23);
            queue.Enqueue(24);
            queue.Dequeue();
            queue.Enqueue(25);
            queue.PrintAllMessages();
            queue.Enqueue(26);
            queue.PrintAllMessages();

            Console.WriteLine("Done");
        }
    }

    public class Queue<T>
    {
        private int length = 10;
        private int filledCount = 0;
        private int firstIn = 0;
        private int lastIn = 0;
        private T defaultMessage;
        private T[] messages;

        public Queue()
        {
            messages = new T[length];
        }

        public T Enqueue(T message)
        {
            if (filledCount >= length)
            {
                ResizeArray();
                //throw new IndexOutOfRangeException("Queue is full");
            }

            messages[lastIn++] = message;
            filledCount++;

            if (lastIn == length)
            {
                lastIn = 0;
            }
            return message;
        }

        public T Dequeue()
        {
            if (filledCount > 0)
            {
                T message = messages[firstIn];
                messages[firstIn] = defaultMessage;
                filledCount--;
                if (firstIn == length - 1)
                {
                    firstIn = 0;
                }
                else
                {
                    firstIn++;
                }
                return message;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public void PrintAllMessages()
        {
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i]?.ToString());// + " - " + lastIn);
            }
            Console.WriteLine("--------------------------");
        }

        private void ResizeArray()
        {
            length *= 2;
            T[] tempMessages = new T[length];

            for (int i = 0; i < filledCount; i++)
            {
                tempMessages[i] = messages[firstIn++];
                if (firstIn == messages.Length)
                {
                    firstIn = 0;
                }
            }
            firstIn = 0;
            lastIn = filledCount;

            //messages.CopyTo(tempMessages, 0);
            messages = tempMessages;
            tempMessages = null;
        }
    }
}
