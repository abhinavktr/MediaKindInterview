using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class StackWithArray
    {
        //https://codeinterview.io/CVEEADZBCZ

        public StackWithArray()
        {
            Console.WriteLine("Hello");

            MyStack<int> stack = new MyStack<int>();
            //Console.WriteLine(stack.Pop());
            stack.Push(10);
            stack.Push(12);
            Console.WriteLine("-->" + stack.Pop());
            stack.PrintAll();
            for (int i = 1; i < 10; i++)
            {
                stack.Push(i);
            }
            stack.PrintAll();
            //stack.Push(22);
            Console.WriteLine("-->" + stack.Pop());
            Console.WriteLine("-->" + stack.Pop());

            Console.WriteLine("Done");
        }
    }

    public class MyStack<T>
    {
        private int length = 10;
        private int pushIndex = 0;
        private T defaultMessage;
        private T[] messages;

        public MyStack()
        {
            messages = new T[length];
        }

        public void Push(T message)
        {
            if (pushIndex >= length)
            {
                throw new ArgumentException("Stack is full");
            }

            messages[pushIndex++] = message;
        }

        public T Pop()
        {
            if (pushIndex < 1)
            {
                throw new NullReferenceException("Stack is empty.");
            }
            T popMessage = messages[pushIndex - 1];

            messages[pushIndex-- - 1] = defaultMessage;
            return popMessage;
        }

        public void PrintAll()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(messages[i]);
            }
            Console.WriteLine("----");
        }
    }
}
