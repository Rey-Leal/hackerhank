using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Pessoa
{
    public override string ToString()
    {
        return "Alterei esse metodo interno kkkk!";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        try
        {
            Pessoa pessoa = new Pessoa();
            int numero = 3242342;
            Console.WriteLine(pessoa.ToString());
            Console.WriteLine(numero.ToString());
        }
        catch (Exception erro)
        {
            Console.WriteLine(erro.Message.ToString());
            Console.ReadLine();
        }
    }
}