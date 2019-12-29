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

namespace ClimbingtheLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] climbingLeaderboard(int[] scores, int[] alice)
            {
                int[] aliceranks = new int[alice.Length];

                int[] singularscores = scores.Distinct().ToArray();
                
                
                for (int i = 0; i < alice.Length; i++)
                {
                    for (int j = 0; j < singularscores.Length; j++)
                    {

                        if (alice[i] > singularscores[j])
                        {
                            aliceranks[i] = j + 1;
                            break;

                        }
                        else if (alice[i] == singularscores[j])
                        {
                            aliceranks[i] = j + 1;
                            break;
                        }
                        else
                        {
                            aliceranks[i] = j + 2;

                        }
                    }
                }
                                
                return aliceranks;



            }


            int scoresCount = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))            ;
            int[] result = climbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));

            
        }
    }
}
