using System.Globalization;

namespace Assignment3_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Resize Array in the lecture
            //Console.WriteLine("_________Resize Array___________");
            //MyList<int> myList = new MyList<int>();
            //MyAdvancedList<int> myAdvancedList = new MyAdvancedList<int>();


            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);
            //myList.Add(6);

            //Console.WriteLine("_________Array Item___________");
            //myList.DisplyAll();

            //Console.WriteLine("_________Array Resizing__________");
            //myAdvancedList.Resize(myList);
            //myAdvancedList.DisplyAll();
            //#endregion

            //#region Assignment1_ArrayUtils
            //Console.WriteLine("_________ Assignment1_ArrayUtils ___________");

            //ArrayUtils arrayUtils = new ArrayUtils();
            //int[] Testarray = { 1, 2, 4, 5, 6, 7, 8 };
            //string[] stringTest = { "Hello", "Hi", "Welcome", "Goodbye" };

            ////for int array
            //Console.WriteLine("------------- Reverse Int Array ------------- ");
            //int [] reverseArray = arrayUtils.ReverseArray(Testarray);
            //for (int i = 0; i < reverseArray.Length; i++)
            //{
            //    Console.WriteLine($"\nIndex {i} :{reverseArray[i]}");
            //}

            ////for string array
            //Console.WriteLine("------------- Reverse String Array ------------- ");
            //string[] stringReverseArray = arrayUtils.ReverseArray(stringTest);
            //for (int i = 0; i < stringReverseArray.Length; i++)
            //{
            //    Console.WriteLine($"\nIndex {i} :{stringReverseArray[i]}");
            //}

            ////Get maximum Value
            //Console.WriteLine("------------- Maximum Value ------------- ");
            //var maxValue = arrayUtils.FindMax(Testarray);
            //Console.WriteLine($"\nTha Maximum Value of Array is :{maxValue}");
            //#endregion

            #region Cache<Tkey,Tvalue>
            Console.WriteLine("------------- Cache<Tkey,Tvalue> ------------- ");
            var cache = new Cache<string, int>(2);

            cache.Add("a", 1);
            cache.Add("b", 2);

            var Avalue = cache.GetValue("c") == 0 ? "Not Found" : cache.GetValue("c").ToString();

            var Cvalue = cache.GetValue("c") == 0 ? "Not Found" : cache.GetValue("c").ToString();
            Console.WriteLine($"\nAvalue is : {Avalue} & Cvlue is  {Cvalue}");

            if (cache.GetValue("b")  != 0)
                Console.WriteLine($"\nb key is value {cache.GetValue("b")}");
            #endregion

            //Console.WriteLine("Hello, World!");
        }
    }
}
