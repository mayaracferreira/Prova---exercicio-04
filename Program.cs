using System;

namespace Prova___Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente("Pedro", 20, 1200.00);
            Supervisor s1 = new Supervisor("Renan", 30, 1000.00);
            Vendedor v1 = new Vendedor("Evy", 20, 500.00);


            g1.bonificao(10000.00);
            s1.bonificao(5000.00);
            v1.bonificao(1000.00);



        }

    }
}
