using System;

namespace reftask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 67, 89 };
            int number = 8;
            Add(ref arr, number);
           
        }
        static void Add(ref int []  arr, int number)
        {
            int[] newArr = new int[arr.Length + 1];
            newArr[arr.Length] = number;
            for(int i = 0; i< arr.Length; i++)
            {
                newArr[i] = arr[i];

            }
            arr = newArr;
            foreach( var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
