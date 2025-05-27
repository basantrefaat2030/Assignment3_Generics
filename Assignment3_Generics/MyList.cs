using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Generics
{
    public class MyList<T>
    {
        protected T[] items;
        protected int index;
        public MyList()
        {
            items = new T[5];
            index = -1;
        }

        public virtual void Add(T item)
        {
            //item.ID
            if (index == items.Length - 1)
                Extend();

            items[++index] = item;
        }

        public T GetByIndex(int index)
        {
            return items[index];
        }

        private void Extend()
        {
            T[] temp = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }

            items = temp;
        }
        public int Count()
        {
            var countItem = items.Length;
            return countItem;
        }
        public virtual void DisplyAll()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"\nthe {i} index : {items[i]}");
            }
        }

    }
}
