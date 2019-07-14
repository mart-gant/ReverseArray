using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array myArray = Array.CreateInstance(typeof(int), 5);
            myArray.SetValue(1, 0);
            myArray.SetValue(2, 1);
            myArray.SetValue(3, 2);
            myArray.SetValue(4, 3);
            myArray.SetValue(5, 4);

            Console.WriteLine("The Array initially contains the following values:");
            PrintIndexAndValues(myArray);

            Array.Reverse(myArray, 1, 3);

            Console.WriteLine("After reversing:");
            PrintIndexAndValues(myArray);
        }


        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }
    }
}
    

