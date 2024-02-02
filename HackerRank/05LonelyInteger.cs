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
//     * Encontra o elemento com apenas uma incidencia no array
//     * Complete the 'lonelyinteger' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts INTEGER_ARRAY a as parameter.
//     */

//    public static int lonelyinteger(List<int> a)
//    {
//        try
//        {
//            int contador = 0;
//            int resultado = 0;

//            for (int n = 0; n < a.Count(); n++)
//            {
//                contador = a.Count(elemento => elemento.Equals(a[n]));
//                if (contador == 1)
//                {
//                    resultado = a[n];
//                    n = a.Count();
//                }
//            }

//            return (resultado);
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

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        int result = Result.lonelyinteger(a);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
