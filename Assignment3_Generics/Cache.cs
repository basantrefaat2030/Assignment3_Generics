using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Generics
{

    public class Cache <TKey, TValue> where TKey : notnull
    {
        private int capacity;
        private Tuple<TKey, TValue>[] items;
        private int[] usageOrder;
        private int count;

        public Cache(int size)
        {
            capacity = size;
            items = new Tuple<TKey, TValue>[capacity];
            usageOrder = new int[capacity];
            count = 0;
        }
        public void Add(TKey key, TValue value) 
        {
        
        }

        
    }
}
