//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;

////Serialização usando Json
//class Pessoa
//{
//    public Pessoa(int id, string nome, string sobrenome, int idade)
//    {
//        Id = id;
//        Nome = nome;
//        Sobrenome = sobrenome;
//        Idade = idade;
//    }

//    public int Id { get; set; }
//    public string Nome { get; set; }
//    [JsonProperty("SobrenomeJSON")]
//    public string Sobrenome { get; set; }
//    public int Idade { get; set; }
//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            List<Pessoa> pessoas = new List<Pessoa>();

//            pessoas.Add(new Pessoa(1, "Joseph", "Climber", 39));
//            pessoas.Add(new Pessoa(2, "Eva", "Parasite", 40));
//            pessoas.Add(new Pessoa(3, "João", "Bulbassa", 75));
//            pessoas.Add(new Pessoa(4, "Gabriela", "Morais", 38));

//            string serializado = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
//            File.WriteAllText($"E:\\ASP.NET\\HackerRank\\HackerRank\\Arquivos\\pessoas.json", serializado);
//            Console.WriteLine(serializado);
//        }
//        catch (Exception erro)
//        {
//            Console.WriteLine(erro.Message.ToString());
//            Console.ReadLine();
//        }
//    }
//}