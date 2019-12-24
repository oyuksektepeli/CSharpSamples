using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace AVeryBigSum
{
    class Program
    {// Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {

            long sum = 0;
            int length = ar.Length;

            if (length >= 1 && length <= 10)
            {
                
                for (int i = 0; i < length; i++)
                {
                    if (Math.Log10(ar[i] + 1) < 10)
                    {
                        sum += ar[i];
                    }
                    else
                    {
                        Console.WriteLine("Digit number should be smaller than 10");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Array size should be between 1 and 10");
            }

            return sum;
        }

        static void Main(string[] args)
        {
           

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
                        
        }
    }
}
