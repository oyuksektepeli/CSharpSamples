﻿using System.CodeDom.Compiler;
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

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", i)).PadLeft(n));
                
            }
            
            

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
