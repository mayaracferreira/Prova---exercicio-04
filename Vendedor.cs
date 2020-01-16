using System;
using System.Collections.Generic;
using System.Text;

namespace Prova___Exercicio_04
{
    class Vendedor: Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

    }
}
