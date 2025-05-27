using System.Globalization;

namespace Assignment3_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Resize Array in the lecture
            MyList<int> myList = new MyList<int>();
            MyAdvancedList<int> myAdvancedList = new MyAdvancedList<int>();


            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            Console.WriteLine("_________Array Item___________");
            myList.DisplyAll();

            Console.WriteLine("_________Resize Array__________");
            myAdvancedList.Resize(myList);
            myAdvancedList.DisplyAll();
            #endregion

            #region Assignment1_ArrayUtils

            ArrayUtils arrayUtils = new ArrayUtils();
            int[] Testarray = { 1, 2, 4, 5, 6, 7, 8 };

            int [] reverseArray = arrayUtils.ReverseArray(Testarray);
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.WriteLine($"A  Reverse Array is {reverseArray[i]}");
            }
            var maxValue = arrayUtils.FindMax(Testarray);

            Console.WriteLine("");
            #endregion

            //Console.WriteLine("Hello, World!");
        }
    }
}
