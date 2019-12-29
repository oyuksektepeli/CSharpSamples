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
using System.Numerics;

class Solution
{

    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n)
    {
        var bigInteger = new BigInteger();
        bigInteger = n;
        for (int i = n-1; i >= 1; i--)
        {
            bigInteger *= i;
            
        }
        Console.WriteLine(bigInteger);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}
