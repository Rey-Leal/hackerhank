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
//     * Complete the 'findMedian' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static int findMedian(List<int> arr)
//    {
//        try
//        {
//            arr.Sort();
//            int meio = arr.Count / 2;
//            return arr[meio];
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

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        int result = Result.findMedian(arr);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
