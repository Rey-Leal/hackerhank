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
//     * Verifica a divisibilidade por 3 e 5 e classifica com FizzBuss, ou retorna indice
//     * Complete the 'fizzBuzz' function below.
//     *
//     * The function accepts INTEGER n as parameter.
//     */

//    public static void fizzBuzz(int n)
//    {
//        try
//        {
//            // Solucao com IFs
//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 3 == 0 && i % 5 == 0)
//                {
//                    Console.WriteLine("FizzBuzz");
//                }
//                else if (i % 3 == 0 && i % 5 != 0)
//                {
//                    Console.WriteLine("Fizz");
//                }
//                else if (i % 3 != 0 && i % 5 == 0)
//                {
//                    Console.WriteLine("Buzz");
//                }
//                else
//                {
//                    Console.WriteLine(i.ToString());
//                }
//            }

//            // Solucao com Switch
//            for (int i = 1; i <= n; i++)
//            {
//                switch (i)
//                {
//                    case var _ when (i % 3 == 0 && i % 5 == 0):
//                        Console.WriteLine("FizzBuzz");
//                        break;
//                    case var _ when (i % 3 == 0 && i % 5 != 0):
//                        Console.WriteLine("Fizz");
//                        break;
//                    case var _ when (i % 3 != 0 && i % 5 == 0):
//                        Console.WriteLine("Buzz");
//                        break;
//                    default:
//                        Console.WriteLine(i.ToString());
//                        break;
//                }
//            }

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

//        Result.fizzBuzz(n);
//    }
//}
