//using System;

//public class Pessoa
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
//    public string Sobrenome { get; set; }
//    public int Idade { get; set; }

//    public virtual void Apresentar()
//    {
//        Console.WriteLine($"Pessoa Id {Id}\tNome {Nome}\tIdade {Idade}");
//    }
//}

//public class Aluno : Pessoa
//{
//    public Aluno(int id, string nome, string sobrenome, int idade) : base(id, nome, sobrenome, idade) { }
    
//    public decimal Nota { get; set; }

//    public override void Apresentar()
//    {
//        Console.WriteLine($"Sou o aluno {Id}\tNome {Nome}\tIdade {Idade}");
//    }

//    public void Boletim()
//    {
//        Console.WriteLine($"Notas: {Nota}");
//    }
//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            Aluno aluno = new Aluno(1, "Joãozinho", "Silva", 6);
//            aluno.Nota = 9.50M;

//            aluno.Apresentar();
//            aluno.Boletim();
//        }
//        catch (Exception erro)
//        {
//            Console.WriteLine(erro.Message.ToString());
//            Console.ReadLine();
//        }
//    }
//}