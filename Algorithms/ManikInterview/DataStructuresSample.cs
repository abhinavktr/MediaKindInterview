using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class DataStructuresSample
    {
        int[] array = new int[10];
        IList<int> list = new List<int>();
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        LinkedList<int> linkedList = new LinkedList<int>();
        IDictionary<int, int> dict = new Dictionary<int, int>();
        HashSet<int> hashSet = new HashSet<int>();
        SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
        
        ISet<int> set;

        public DataStructuresSample()
        {
            list.Add(1);
            list.Count();
            list.Insert(0, 10);
            list.Remove(10);
            list.RemoveAt(0);
                        
            queue.Enqueue(1);
            queue.Dequeue();
            
            stack.Push(10);
            stack.Peek();
            stack.Pop();

            LinkedListNode<int> linkedListNode = new LinkedListNode<int>(30);
            linkedList.AddFirst(linkedListNode);            
            linkedList.AddAfter(linkedListNode, 25);
            linkedList.AddBefore(linkedListNode, 45);
            linkedList.AddFirst(55);
            linkedList.AddLast(65);
            linkedList.Find(25);
            linkedList.FindLast(35);
            linkedList.Last();
            linkedList.Remove(45);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            dict.Add(1, 2);
            //dict.Add(1, 2);
            //dict.Contains(new KeyValuePair<int, int>(1, 2));
            dict.ContainsKey(1);
            ICollection<int> keys = dict.Keys;
            dict.Remove(1);
            ICollection<int> value = dict.Values;
            dict.Add(1, 20);
            //int val =  dict[12]; //throw new KeyNotFoundException

            hashSet.Add(10);
            hashSet.Add(10);
            hashSet.IsSubsetOf(new List<int>());
            hashSet.IsSupersetOf(new List<int>());
            hashSet.Remove(10);

            //Array.Copy()
            array.Clone();
            //array.CopyTo(,);
            //Array.Resize();
        }
    }
}