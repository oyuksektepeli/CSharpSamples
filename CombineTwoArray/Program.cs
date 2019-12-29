using System;
using System.Collections.Generic;

namespace CombineTwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            var combined = new List<int>();
            combined.AddRange(arr1);
            combined.AddRange(arr2);
            Array.Sort(combined.ToArray());

            foreach (var item in combined)
            {
                Console.WriteLine(item);
            }


        }
    }
}
