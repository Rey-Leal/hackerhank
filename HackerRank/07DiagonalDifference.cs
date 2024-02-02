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
//     * Calcula a diferenca entre as diagonais de uma matriz
//     * Complete the 'diagonalDifference' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
//     */

//    public static int diagonalDifference(List<List<int>> arr)
//    {
//        try
//        {
//            int linhas = arr.Count;
//            int diagonalEsquerda = 0;
//            int diagonalDireita = 0;
//            int diferenca = 0;

//            for (int i = 0; i < linhas; i++)
//            {
//                int colunas = arr[i].Count;

//                diagonalEsquerda += arr[i][i];
//                diagonalDireita += arr[i][colunas - 1 - i];
//            }

//            // Resultado sempre em numero absoluto
//            diferenca = Math.Abs(diagonalEsquerda - diagonalDireita);
//            return diferenca;

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
//        // Entrada padrao via Console
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<List<int>> arr = new List<List<int>>();

//        for (int i = 0; i < n; i++)
//        {
//            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//        }        

//        //Entrada via Matriz de Array
//        //int[][] arr = new int[][]
//        //{
//        //    new int[] {1,2,3},
//        //    new int[] {4,5,6},
//        //    new int[] {9,8,9}
//        //};

//        // Entrada via Matriz de Lista
//        //var arr = new List<List<int>>();
//        //List<int>
//        //linha = new List<int>() { 1, 2, 3 };
//        //arr.Add(linha.ToList());
//        //linha = new List<int>() { 4, 5, 6 };
//        //arr.Add(linha.ToList());
//        //linha = new List<int>() { 9, 8, 9 };
//        //arr.Add(linha.ToList());

//        int result = Result.diagonalDifference(arr);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
