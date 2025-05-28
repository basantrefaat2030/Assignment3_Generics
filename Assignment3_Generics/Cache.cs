using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Generics
{

    public class Cache <TKey, TValue> where TKey : notnull
    {
        private  Dictionary<TKey, TValue> items = new();
        private  List<TKey> LruList = new();
        private readonly int capacity;
        public Cache(int fixedSize)
        {
            capacity = fixedSize;

        }
        public void Add(TKey key, TValue value)
        {
            if (items.ContainsKey(key))
            {
                //update
                items[key] = value;
                RecentlyUsed(key);
            }
            else
            {
                if (items.Count >= capacity)
                {
                    items.Remove(LruList[0]);
                    LruList.RemoveAt(0);
                }
            }
            //add
            items.Add(key, value);
            LruList.Add(key);
        }

        public bool Remove(TKey key)
        {
            bool removed = false;

            if (key != null)
            {
                removed = items.Remove(key);

                if (removed)
                    LruList.Remove(key);
            }

            return removed;
        }

        public TValue GetValue(TKey key)
        {
            if (key != null)
            {
                if (items.ContainsKey(key))
                    return items[key];


                RecentlyUsed(key);
            }
            return default;

        }
        public string GetLRUList() 
        {
           return string.Join(",", LruList);
        }
        private void RecentlyUsed(TKey key)
        {
            LruList.Remove(key);
            LruList.Add(key);
        }

       
    }
}
