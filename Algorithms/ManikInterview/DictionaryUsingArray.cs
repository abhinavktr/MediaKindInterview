using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class DictionaryUsingArray
    {
        //https://codeinterview.io/PQCKCEEAMV
        public DictionaryUsingArray()
        {
            MyDictionary<int, int> dict = new MyDictionary<int, int>();
            dict.Add(10, 20);
            dict.Add(12, 24);
            dict.PrintDictionary();
            dict.Remove(10);
            dict.PrintDictionary();
            //dict.Add(12, 34);
            for (int i = 13; i < 25; i++)
            {
                dict.Add(i, i * 2);
            }
            dict.PrintDictionary();
        }
    }

    public class MyDictionary<T, U>
    {
        private int length = 10;
        private int fillAt = 0;
        private T[] keys;
        private U[] values;
        private T defaultKey;
        private U defaultValue;

        public MyDictionary()
        {
            keys = new T[length];
            values = new U[length];
        }

        public void Add(T key, U val)
        {
            if (GetKeyIndex(key) > -1)
            {
                throw new ArgumentException("Key already exists.");
            }

            if (fillAt >= length)
            {
                ResizeArray();
            }

            keys[fillAt] = key;
            values[fillAt] = val;

            fillAt++;
        }

        public bool Remove(T key)
        {
            int keyIndex = GetKeyIndex(key);
            if (keyIndex > -1)
            {
                Array.Copy(keys, keyIndex + 1, keys, keyIndex, length - 1 - keyIndex);
                keys[length - 1] = defaultKey;
                Array.Copy(values, keyIndex + 1, values, keyIndex, length - 1 - keyIndex);
                values[length - 1] = defaultValue;
                fillAt--;
            }
            else
            {
                throw new KeyNotFoundException("Key not found");
            }
            return true;
        }

        public void PrintDictionary()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Key: {keys[i]} - Value: {values[i]}");
            }
            Console.WriteLine("--------------------------------");
        }

        private int GetKeyIndex(T key)
        {
            int keyIndex = -1;
            for (int i = 0; i < length; i++)
            {
                if (keys[i].Equals(key))
                {
                    keyIndex = i;
                    break;
                }
            }
            return keyIndex;
        }

        private void ResizeArray()
        {
            length *= 2;
            T[] keysTemp = new T[length];
            U[] valuesTemp = new U[length];

            keys.CopyTo(keysTemp, 0);
            values.CopyTo(valuesTemp, 0);

            keys = keysTemp;
            values = valuesTemp;

            keysTemp = null;
            valuesTemp = null;
        }
    }

}
