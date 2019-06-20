using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class HashMapSample
    {
        //https://codeinterview.io/WAUFCCCZOR
        public HashMapSample()
        {
            Console.WriteLine("Hello");

            HashMap<string, string> keyvalue = new HashMap<string, string>();
            keyvalue.Add("suresh", "suresh1");
            keyvalue.Add("suresh2", "suresh3");

            Console.WriteLine(keyvalue["suresh"]);
            Console.WriteLine(keyvalue["suresh2"]);

        }
    }

    public class HashMap<TKey, TVal>
    {
        HashMapNode<TKey, TVal>[] HashMapNode;
        int defaultLenght = 10;
        public HashMap()
        {
            HashMapNode = new HashMapNode<TKey, TVal>[defaultLenght];
        }

        public void Add(TKey key, TVal val)
        {

            HashMapNode<TKey, TVal> node = new HashMapNode<TKey, TVal>(key, val);
            int hashCode = Math.Abs(key.GetHashCode());
            int index = GetIndex(hashCode);


            if (HashMapNode[index] != null)
            {
                HashMapNode<TKey, TVal> hashTemp = HashMapNode[index];

                do
                {
                    if (hashTemp.hashCode == hashCode)
                    {
                        Console.WriteLine("Key is already exists");
                        return;
                    }
                    else
                    {
                        hashTemp = hashTemp.nextNode;
                    }

                } while (hashTemp.nextNode != null);


                hashTemp.nextNode = node;
            }
            else
            {
                HashMapNode[index] = node;
            }

        }

        public TVal this[TKey key]
        {
            get { return this.GetValue(key); }
        }

        public TVal GetValue(TKey key)
        {
            int hashCode = Math.Abs(key.GetHashCode());
            int index = GetIndex(hashCode);

            if (HashMapNode[index] != null)
            {
                HashMapNode<TKey, TVal> node = HashMapNode[index];
                do
                {

                    if (node.hashCode == hashCode)
                    {
                        return node.data;
                    }
                    else
                    {
                        node = node.nextNode;
                    }

                } while (node.nextNode != null);
                return default(TVal);
            }
            else
            {
                Console.WriteLine("Key not exists");
                return default(TVal);
            }

        }

        public int GetIndex(int hashCode)
        {
            return hashCode % defaultLenght;
        }
    }

    public class HashMapNode<TKey, TVal>
    {
        public TVal data;
        public TKey _key;
        public HashMapNode<TKey, TVal> nextNode;
        public int hashCode;

        public HashMapNode(TKey key, TVal val)
        {
            data = val;
            nextNode = null;
            key = key;
            hashCode = Math.Abs(key.GetHashCode());
        }
    }
}