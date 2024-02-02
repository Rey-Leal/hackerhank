using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Constroi uma escada de caracteres espaco e # de acordo com parametro n
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        try
        {
            for (int i = 1; i <= n; i++)
            {
                // Espacos em branco
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Caracter ao final
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                // Quebra linhas
                Console.WriteLine();
            }
        }
        catch (Exception erro)
        {
            throw erro;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
        Console.ReadLine();
    }
}
