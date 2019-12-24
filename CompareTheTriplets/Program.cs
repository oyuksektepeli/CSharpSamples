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

namespace CompareTheTriplets
{
    class Solution
    {

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var points = new List<int>();
            var members = 3;
            var alicepoints = 0;
            var bobpoints = 0;

            if (a.Count == b.Count)
            {
                for (int i = 0; i < members; i++)
                {
                    if (a[i] > b[i])
                    {
                        ++alicepoints;

                    }
                    else if (a[i] < b[i])
                    {
                        ++bobpoints;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            else
            {
                Console.WriteLine("Each member should have three points");
            }

            points.Add(alicepoints);
            points.Add(bobpoints);
            


            return points;
        }

        class Program
        {
            static void Main(string[] args)
            {


                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

                List<int> result = compareTriplets(a, b);

                Console.WriteLine(String.Join(" ", result));

            }
        }
    }
}
