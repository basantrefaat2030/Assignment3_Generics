using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Generics
{
    public class MyAdvancedList<TSource>:MyList<TSource>
    {
        TSource[] resizeArray;
        public MyAdvancedList() :base()
        { 
            
        
        }
        public void Resize(MyList<TSource> sourceList)
        {
            
            int count = 0;
            int resizeindex = 0;


            for (int i = 0; i <= sourceList.Count() -1 ; i++)
            {

                if (!IsValidValue(sourceList.GetByIndex(i)))
                    count++;
            }


            resizeArray = new TSource[count];

            for (int i = 0; i <= sourceList.Count() - 1; i++)
            {

                if (!IsValidValue(sourceList.GetByIndex(i)))
                {
                    resizeArray[resizeindex] = sourceList.GetByIndex(i);
                    resizeindex++;
                }

                items = resizeArray;
                index = resizeindex -1;
            }

        }
        //this check on any type struct or refrece
        private bool IsValidValue(TSource value)
        {
            return EqualityComparer<TSource>.Default.Equals(value, default(TSource));
        }

        public override void DisplyAll()
        {
            for (int i = 0; i < resizeArray.Length; i++)
            {
                Console.WriteLine($"\nDisply ResizeArray With {i} index : {resizeArray[i]}");
            }
        }

    }
}
