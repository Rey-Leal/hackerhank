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
//     * Complete the 'countingSort' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static List<int> countingSort(List<int> arr)
//    {
//        try
//        {
//            // Lista de 100 elementos preenchidas com 0
//            List<int> result = new List<int>();
//            result.AddRange(Enumerable.Repeat(0, 100));

//            // Cria nova lista 
//            for (int i = 0; i < arr.Count(); i++)
//            {
//                result[arr[i]]++;
//            }

//            return result;
//        }
//        catch (Exception erro)
//        {
//            throw (erro);
//        }
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        List<int> result = Result.countingSort(arr);

//        Console.WriteLine(String.Join(" ", result));
//        Console.ReadLine();
//    }
//}
