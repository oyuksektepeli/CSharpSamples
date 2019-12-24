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

namespace PlusMinus
{
   
        
    

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            var length = arr.Length;
            var plus = 0;
            var minus = 0;
            var zero = 0;
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 6;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    ++plus;
                }
                else if (arr[i] < 0)
                {
                    ++minus;
                }
                else if (arr[i] == 0)
                {
                    ++zero;
                }
            }

            Console.WriteLine(((float)plus / (float)length).ToString("N",setPrecision));
            Console.WriteLine(((float)minus / (float)length).ToString("N", setPrecision));
            Console.WriteLine(((float)zero / (float)length).ToString("N", setPrecision));
        }
    }
}
