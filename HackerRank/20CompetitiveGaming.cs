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
     * Complete the 'numPlayers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY scores
     */

    public static int numPlayers(int k, List<int> scores)
    {
        try
        {
            //k=nota de corte
            scores.Sort();
            scores.Reverse();

            int subirDeLevel = 0;
            int ranking = 1;
            int ultimoScore = scores[0];
            List<int> listaRanking = new List<int>();

            foreach (int pontos in scores)
            {
                if (pontos < ultimoScore)
                {
                    ranking++;
                    listaRanking.Add(ranking);
                }
                ultimoScore = pontos;
            }

            foreach (int pontos in listaRanking)
            {
                if (pontos > k)
                {
                    subirDeLevel++;
                }
            }

            return subirDeLevel;

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
        int k = Convert.ToInt32(Console.ReadLine().Trim());

        int scoresCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = new List<int>();

        for (int i = 0; i < scoresCount; i++)
        {
            int scoresItem = Convert.ToInt32(Console.ReadLine().Trim());
            scores.Add(scoresItem);
        }

        int result = Result.numPlayers(k, scores);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
