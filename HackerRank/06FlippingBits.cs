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
//     * Complete the 'flippingBits' function below.
//     *
//     * The function is expected to return a LONG_INTEGER.
//     * The function accepts LONG_INTEGER n as parameter.
//     */

//    public static long flippingBits(long n)
//    {
//        try
//        {
//            // Coverter int64 para bits
//            string binario = Convert.ToString(n, 2);
//            binario = binario.PadLeft(32, '0');

//            char[] bits = binario.ToCharArray();

//            // Flippar bits 0->1 1->0
//            for (int i = 0; i < bits.Length; i++)
//            {
//                if (bits[i] == '0')
//                    bits[i] = '1';
//                else
//                    bits[i] = '0';
//            }

//            string flipper = new string(bits);
//            flipper = flipper.PadLeft(32, '0');

//            // Converter bits para int64
//            Int64 resultado = Convert.ToInt64(flipper, 2);

//            return resultado;
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
//            long n = Convert.ToInt64(Console.ReadLine().Trim());

//            long result = Result.flippingBits(n);

//            Console.WriteLine(result);
//        }
//        Console.ReadLine();
//    }
//}
