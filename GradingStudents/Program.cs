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

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

            
        }

        class Result
        {
            
            public static List<int> gradingStudents(List<int> grades)
            {
                var studentgrades = new List<int>();
                int  studentgrade = 0;

                foreach (var grade in grades)
                {
                    var reminder = grade % 5;

                    if(grade > 37 & reminder >= 3 )
                    {
                        studentgrade = grade + (5 - reminder);
                        studentgrades.Add(studentgrade);
                    }
                    else
                    {
                        studentgrades.Add(grade);
                    }

                    
                }

                return studentgrades;
            }

        }
    }
}
