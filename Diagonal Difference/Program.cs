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

namespace Diagonal_Difference
{
    public class Result
    {
        /*
        * Complete the 'diagonalDifference' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int difference = 0;
            int listLength = arr.Count;
            
            int leftsum = 0;
            int rightsum = 0;
            int j = listLength;


            for (int i = 0; i < listLength; i++)
            {
                
                --j;
                List<int> a = arr[i];
                leftsum += a[i];
                rightsum += a[j];
                
            }
            
            difference = Math.Abs(leftsum - rightsum);
            
            
            return difference;


        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
           
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            
            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
            

            
        }
    }
}
