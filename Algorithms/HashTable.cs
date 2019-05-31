using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HashTable<TKey, TValue>
    {
        //using array
        private LinkedList<int>[] _array;

        private bool _fillFactor;

        private int _arraySize = 8;

        public HashTable()
        {
            if (_array != null)
                _array = new LinkedList<int>[_arraySize];

            _fillFactor = (_array.Length / _arraySize) < 1;

            //todo: check at add
            if(!_fillFactor)
            {
                //double the array size
            }
        }

        //add

        //remove
    }


}
