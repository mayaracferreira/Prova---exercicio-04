using System;
using System.Collections.Generic;
using System.Text;

namespace Prova___Exercicio_04
{
    abstract class Funcionario
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
    


        public Funcionario ()
    {

    }
        public Funcionario (string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }


        public void bonificao(double boni)
        {

            Console.WriteLine(" Salário : " + (Salario + boni));
          

        }

        
    }

}

