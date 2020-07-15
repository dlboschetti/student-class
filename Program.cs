using System;

namespace student_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            aluno.Nome = "Lucas Moura Boschetti";
            aluno.Idade = 4;
            aluno.Periodo = "Tarde";
            aluno.Serie = "Jardim I";
            aluno.Sexo = "Masculino";

            Console.WriteLine($"informar notas do aluno {aluno.Nome} :");
            Console.WriteLine("Nota1:");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota2:");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            aluno.AplicarNota(nota1, nota2);

            aluno.ImprimirNota();
            
        }
    }
}
