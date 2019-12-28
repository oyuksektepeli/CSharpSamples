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

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int candles = 0;
            int max = ar.Max();

            foreach (var item in ar)
            {
                if(item == max)
                {
                    candles += 1;
                }
            }

            return candles;
        }

        static void Main(string[] args)
        {
            

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            Console.WriteLine(result);

        }
    }
}
