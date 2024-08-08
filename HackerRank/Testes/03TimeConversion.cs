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
//     * Converte horas 12 horas AM/PM em formato militar 24hs
//     * Complete the 'timeConversion' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string timeConversion(string s)
//    {
//        try
//        {
//            int horas = Int32.Parse(s.Substring(0, 2));
//            int minutos = Int32.Parse(s.Substring(3, 2));
//            int segundos = Int32.Parse(s.Substring(6, 2));
//            string horasConvertida = "";

//            if (s.Contains("PM"))
//            {
//                // PM 1..11 = H + 12, 12 = 12                
//                if (horas >= 1 && horas <= 11)
//                {
//                    horas += 12;
//                }
//                horasConvertida = String.Concat(horas.ToString("D2"), ":", minutos.ToString("D2"), ":", segundos.ToString("D2"));
//            }
//            else
//            {
//                // AM 1..11 = H, 12 = 00                
//                if (horas == 12)
//                {
//                    horas = 0;
//                }
//                horasConvertida = String.Concat(horas.ToString("D2"), ":", minutos.ToString("D2"), ":", segundos.ToString("D2"));
//            }

//            return (horasConvertida);
//        }
//        catch (Exception erro)
//        {
//            return (erro.Message.ToString());
//        }
//    }
//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        string s = Console.ReadLine();

//        string result = Result.timeConversion(s);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
