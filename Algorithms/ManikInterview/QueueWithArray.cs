using System;

namespace ConsoleAppOne
{
    public class QueueWithArray
    {
        public void QueueWithArraySample()
        {
            Console.WriteLine("Hello");

            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Dequeue();
            queue.Enqueue("Four");
            queue.Enqueue("Five");
            queue.Dequeue();
            queue.Enqueue("Six");
            queue.Enqueue("Seven");
            queue.Enqueue("Eight");
            queue.Enqueue("Nine");
            queue.Dequeue();


            queue.Print();

            Console.WriteLine("Done");
        }

    }

    public class MyQueue<T>
    {
        int length = 5;
        int currentLength = 0;
        T[] array;

        public MyQueue()
        {
            array = new T[length];
        }

        public void Enqueue(T value)
        {
            if (currentLength < length)
            {
                array[currentLength] = value;
                currentLength++;
            }
            else
            {
                T[] bigArray = new T[currentLength + currentLength];
                array.CopyTo(bigArray, 0);
                array = bigArray;
                array[currentLength] = value;
                currentLength++;
                bigArray = null;
            }
        }

        public T Dequeue()
        {
            if (currentLength < 1)
            {
                throw new IndexOutOfRangeException("No values in Queue");
            }

            T value = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            currentLength--;

            return value;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

}