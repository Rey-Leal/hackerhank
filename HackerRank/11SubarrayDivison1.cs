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
//     * Complete the 'birthday' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY s
//     *  2. INTEGER d
//     *  3. INTEGER m
//     */

//    public static int birthday(List<int> s, int d, int m)
//    {
//        try
//        {
//            // s barra
//            // d soma dos pedacos
//            // m tamanho dos pedacos
//            // ? quantas pedacos consigo dividir no tamanho d
            
//            // MODO 1
//            int result = 0;

//            // Apenas 1 elemento
//            if (s.Count == 1)
//            {
//                if (s[0] == d)
//                {
//                    result++;
//                }
//            }
//            // Mais de 1 elemento 
//            else
//            {
//                for (int i = 0; i < s.Count - m; i++)
//                {
//                    // Percorre array com intervalos sequenciais de pedacos m
//                    int pedaco = s.Skip(i).Take(m).Sum();

//                    if (pedaco == d)
//                    {
//                        result++;
//                    }
//                }
//            }
//            return result;

//            // MODO 2
//            //int divisionCount = 0;

//            //for (int i = 0; i < s.Count; i++)
//            //{
//            //    int last = i + m - 1;
//            //    int sum = 0;
//            //    if (last < s.Count)
//            //    {
//            //        for (int j = i; j <= last; j++)
//            //        {
//            //            sum += s[j];
//            //        }
//            //    }
//            //    if (sum == d)
//            //    {
//            //        divisionCount++;
//            //    }
//            //}
//            //return divisionCount;
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
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int d = Convert.ToInt32(firstMultipleInput[0]);

//        int m = Convert.ToInt32(firstMultipleInput[1]);

//        int result = Result.birthday(s, d, m);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
