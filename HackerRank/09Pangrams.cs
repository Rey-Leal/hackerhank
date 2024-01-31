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
//     * Complete the 'pangrams' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string pangrams(string s)
//    {
//        try
//        {
//            string result = "not pangram";

//            // space=32 A~Z=65~90 a~z=97~122 intervalo 26
//            // Lista de controle do pangrama preenchidas com 0-false
//            List<int> letras = new List<int>();
//            letras.AddRange(Enumerable.Repeat(0, 26));

//            // Transforma em maiusculo e retira espacos
//            string entrada = s.ToUpper().Replace(" ", "");

//            for (int i = 0; i < entrada.Length; i++)
//            {
//                // Define com valor 1 caso encontre letra
//                int ascii = Convert.ToInt32(entrada[i]);
//                // Considera apenas letras maisculas
//                if (ascii >= 65 && ascii <= 90)
//                {
//                    letras[ascii - 65] = 1;
//                }
//            }

//            int soma = letras.Sum();

//            // Soma array deve resultar sempre 26
//            if (soma == 26)
//            {
//                result = "pangram";
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
//        string s = Console.ReadLine();

//        string result = Result.pangrams(s);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
