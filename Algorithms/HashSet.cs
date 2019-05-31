using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
            this.Next = null;
        }
        public T Value;
        public Node<T> Next;
    }
    public class HashSet<T>
    {
        private int _bucketSize = 8;
        private Node<T>[] _arrayOfList;

        public HashSet(int bucketSize)
        {
            _bucketSize = bucketSize;
            if (_arrayOfList == null)
                _arrayOfList = new Node<T>[_bucketSize];
        }
    
        public bool Add(T item)
        {
            //get hashcode
            var hashCode = Math.Abs(item.GetHashCode());
            //get the index
            var index = hashCode % _bucketSize;
            var currentLL = _arrayOfList[index];
            if (currentLL == null)
            {
                _arrayOfList[index] = new Node<T>(item);
                return true;
            }
            while (true)
            {
                if (currentLL.Value.Equals(item))
                    throw new ArgumentException("Value Exits");
                if (currentLL.Next == null) break;
                currentLL = currentLL.Next;

            }
            currentLL.Next = new Node<T>(item);
            return true;
        }
    }
}
        

        //Delete
    

