//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{

//    /*
//     * Compara elementos de dois arrays, retornando a contagem em outro array
//     * Complete the 'compareTriplets' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY a
//     *  2. INTEGER_ARRAY b
//     */

//    public static List<int> compareTriplets(List<int> a, List<int> b)
//    {
//        try
//        {
//            List<int> resultado = new List<int>();
//            resultado.Add(0);
//            resultado.Add(0);

//            for (int i = 0; i < a.Count; i++)
//            {
//                if (a[i] > b[i])
//                {
//                    resultado[0]++;
//                }
//                else if (a[i] < b[i])
//                {
//                    resultado[1]++;
//                }
//            }

//            return resultado;
//        }
//        catch (Exception erro)
//        {
//            throw erro;
//        }
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

//        List<int> result = Result.compareTriplets(a, b);

//        Console.WriteLine(String.Join(" ", result));
//        Console.ReadLine();
//    }
//}
