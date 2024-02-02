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
//     * Separa array em um com os menores numeros e outro com os maiores numeros e depois realiza a soma dos mesmos
//     * Complete the 'miniMaxSum' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static void miniMaxSum(List<int> arr)
//    {
//        try
//        {
//            int[] menoresNumeros = Array.Empty<int>();
//            int[] maioresNumeros = Array.Empty<int>();
//            Int64 somaMenores = 0;
//            Int64 somaMaiores = 0;

//            // Verifica se todos elementos sao iguais 
//            bool elementosIguais = arr.All(elemento => elemento.Equals(arr[0]));

//            // Descarta elementos extremos conforme necessario
//            if (elementosIguais)
//            {
//                menoresNumeros = arr.ToArray();
//                maioresNumeros = arr.ToArray();
//            }
//            else
//            {
//                menoresNumeros = arr.Where(e => e != arr.Max()).ToArray();
//                maioresNumeros = arr.Where(e => e != arr.Min()).ToArray();
//            }

//            // Percorre todos elementos (-1 se todos iguais) convertendo para evitar overflow
//            for (int i = 0; i < menoresNumeros.Count() - (elementosIguais ? 1 : 0); i++)
//            {
//                somaMenores += Int64.Parse(menoresNumeros[i].ToString());
//            }

//            for (int i = 0; i < maioresNumeros.Count() - (elementosIguais ? 1 : 0); i++)
//            {
//                somaMaiores += Int64.Parse(maioresNumeros[i].ToString());
//            }

//            Console.WriteLine(somaMenores + " " + somaMaiores);
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

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.miniMaxSum(arr);
//    }
//}
