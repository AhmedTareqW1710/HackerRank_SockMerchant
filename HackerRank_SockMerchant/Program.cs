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

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int numberOFPairs = 0;
        List<int> pairIndexes =new List<int>();

        for (int i = 0; i < ar.Length; i++)
        {

            for (int j = i + 1; j < ar.Length; j++)
            {
                if (pairIndexes.Contains(i))
                    continue;
                else
                {
                    if (ar[i] == ar[j])
                    {
                        numberOFPairs++;
                        pairIndexes.Add(j);
                        break;
                    }

                }
            }

        }
        return numberOFPairs;

    }

    static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
