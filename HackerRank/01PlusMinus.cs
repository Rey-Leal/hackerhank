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
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static void plusMinus(List<int> arr)
//    {
//        try
//        {
//            int quantidade = arr.Count;
//            int positivos = 0;
//            int negativos = 0;
//            int zeros = 0;

//            for (int i = 0; i < quantidade; i++)
//            {
//                if (arr[i] > 0)
//                {
//                    positivos++;
//                }
//                else if (arr[i] < 0)
//                {
//                    negativos++;
//                }
//                else if (arr[i] == 0)
//                {
//                    zeros++;
//                }
//            }
//            Console.WriteLine("{0:F6}", (float)positivos / quantidade);
//            Console.WriteLine("{0:F6}", (float)negativos / quantidade);
//            Console.WriteLine("{0:F6}", (float)zeros / quantidade);
//            Console.ReadLine();
//        }
//        catch (Exception erro)
//        {
//            Console.WriteLine(erro.Message.ToString());
//            Console.ReadLine();
//        }
//    }
//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.plusMinus(arr);
//    }
//}
