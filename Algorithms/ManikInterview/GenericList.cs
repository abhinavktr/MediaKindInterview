using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class GenericList
    {
        public GenericList()
        {
            MyList<int> list = new MyList<int>();

            for (int i = 10; i < 30; i++)
            {
                list.Add(i);
            }
            list.Remove(23);
            list.PrintAll();
        }
    }

    public class MyList<T>
    {
        private int length = 10;
        private int filledTill = 0;
        private T[] collection;
        private T defaultValue;

        public MyList()
        {
            collection = new T[length];
        }

        public void Add(T element)
        {
            if (filledTill >= length)
            {
                ResizeArray();
            }
            collection[filledTill++] = element;
        }

        public void Remove(T element)
        {
            int elementIndex = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Equals(element))
                {
                    elementIndex = i;
                    break;
                }
            }

            //for (int i = elementIndex; i < collection.Length - 1; i++)
            //{
            //    collection[i] = collection[i + 1];
            //}
            Array.Copy(collection, elementIndex + 1, collection, elementIndex, collection.Length - elementIndex - 1);
            collection[collection.Length - 1] = defaultValue;
        }

        public void ResizeArray()
        {
            length *= 2;
            T[] tempCollection = new T[length];
            collection.CopyTo(tempCollection, 0);
            collection = tempCollection;
            tempCollection = null;
        }

        public void PrintAll()
        {
            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine(collection[i]);
            }
        }
    }
}
