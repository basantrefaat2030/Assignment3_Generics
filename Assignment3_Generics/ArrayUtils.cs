using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Generics
{
    public class ArrayUtils 
    {

        //apply any type
        public T[] ReverseArray<T>(T[] array)
        {
            T[] reArray = new T[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reArray[array.Length - i - 1] = array[i];
            }

            return reArray;
            
        }
        //apply only struct type
        public  T FindMax<T>(T[] array) where T : struct , IComparable<T> 
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            T max = array[0];
            //start from index = 1 for a max equal the first value 
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }

           return max;
        }
    }
}
