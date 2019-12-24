using System;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            Console.WriteLine(result);

        }

        static int simpleArraySum(int[] ar)
        {
            
            int sum = 0;
            int length = ar.Length;

            for (int i = 0; i < length; i++)
            {

                sum += ar[i];
            }
            return sum;
        }
    }
}
