using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Collections;

namespace ConsoleAppOne
{
    class DictionaryWithHashmap
    {
        public DictionaryWithHashmap()
        {
            Console.WriteLine("Hello");
            string hello = "How are you?";
            MyHashMap<string, int> studentScoreList = new MyHashMap<string, int>(1000);
            string[] strings = new string[1000];

            // add 1000 keys and values
            for (int i = 0; i < 1000; i++)
            {
                strings[i] = "str" + i.ToString();
                studentScoreList.Add(strings[i], i + 1000);
            }


            //Search all the keys and get the values
            int scoreValue;
            for (int i = 0; i < 1000; i++)
            {
                //Search the key 
                scoreValue = studentScoreList.GetValue(strings[i]);
                Console.WriteLine($"{strings[i]} :{scoreValue} ", scoreValue);
                // if ((i + 1) % 4 == 0) Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
        public KeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    public class MyHashMap<TKey, TValue>
    {

        KeyValuePair<TKey, TValue>[] mKeyValuePair;
        int mCapacity;
        int mCount;
        public MyHashMap(int capacity)
        {

            mKeyValuePair = new KeyValuePair<TKey, TValue>[capacity];
            mCapacity = capacity;
            mCount = 0;
        }

        private int GetMapValue(TKey key)
        {

            int mapValue = 0;
            int newMapValue = 0;
            int hashCode = Math.Abs(key.GetHashCode());
            int index = 0;
            int divisor = 10;

            while (newMapValue < mCapacity)
            {
                mapValue = newMapValue;
                newMapValue = hashCode % divisor;
                divisor = divisor * 10;
            }
            // Console.WriteLine($"HasCode:{hashCode};mapValue:{mapValue}");
            return mapValue;


        }

        public void Add(TKey key, TValue value)
        {
            if (mCount == mCapacity) throw new InvalidOperationException("Hash Map is full");
            int mapValue = GetMapValue(key);
            int slotIndex = -1;
            for (int index = mapValue; ;)
            {
                // if (EqualityComparer<TKey>.Equals((object)mKeyValuePair[index].Key,default(TKey))) 
                if (mKeyValuePair[index] == null)

                {
                    slotIndex = index;
                    break;
                }
                else if (mKeyValuePair[index].Key.Equals(key))

                {
                    throw new InvalidOperationException("Key Already Exists  in the hash map");
                }
                index++;
                if (index == mCapacity) index = 0;
                if (index == mapValue) break;
            }
            mKeyValuePair[slotIndex] = new KeyValuePair<TKey, TValue>(key, value);
            mCount++;


        }
        public TValue GetValue(TKey key)
        {

            int mapValue = GetMapValue(key);
            bool found = false;
            int index = mapValue;
            int searchCount = 0;
            while (true)
            {
                searchCount++;
                if (mKeyValuePair[index] == null)
                {

                    break;
                }
                else if (mKeyValuePair[index].Key.Equals(key))

                {
                    found = true;
                    break;
                }
                index++;
                if (index == mCapacity) index = 0;
                if (index == mapValue) break;
            }
            Console.Write($"Hit Count:{searchCount} ");
            if (found)
                return mKeyValuePair[index].Value;

            return default(TValue);
        }

    }
}