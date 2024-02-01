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
//     * Complete the 'twoArrays' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts following parameters:
//     *  1. INTEGER k
//     *  2. INTEGER_ARRAY A
//     *  3. INTEGER_ARRAY B
//     */

//    public static string twoArrays(int k, List<int> A, List<int> B)
//    {
//        try
//        {
//            // q=numero de queries
//            // A=[n] B=[n] n=tamanho             
//            // k=target da soma
//            bool comparador = true;

//            // A=crescente
//            A.Sort();
//            // B=decrescente
//            B.Sort((x, y) => y.CompareTo(x));

//            for (int i = 0; i < A.Count; i++)
//            {
//                if (A[i] + B[i] < k)
//                {
//                    comparador = false;
//                    i = A.Count;
//                }
//            }

//            if (comparador)
//            {
//                return "YES";
//            }
//            else
//            {
//                return "NO";
//            }
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
//        int q = Convert.ToInt32(Console.ReadLine().Trim());

//        for (int qItr = 0; qItr < q; qItr++)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int k = Convert.ToInt32(firstMultipleInput[1]);

//            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

//            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

//            string result = Result.twoArrays(k, A, B);

//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//    }
//}
