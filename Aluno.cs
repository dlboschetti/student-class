using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace student_class
{
    class Aluno
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Periodo { get; set; }
        public string Serie { get; set; }
        public double mediaNota;

        public void AplicarNota(int nota1, int nota2)
        {
               mediaNota = (nota1 + nota2)/2;  
        }

        public void  ImprimirNota()
        {
            Console.WriteLine($"A média da(o) Aluna(o) {Nome} da série {Serie} periodo {Periodo} foi de {mediaNota}");
        }
    }
}
