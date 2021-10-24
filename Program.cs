using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {   
              
            emprestimo decimal , rendaMensal , parcelas , credito;

            Console.WriteLine("Bem vindo a Analise de Crédito. \n");

            Console.Write("Informe o valor do empréstimo ....:");
            emprestimo = Convert.ToDecimal (Console.ReadLine());

            Console.Write ("Informe a Quantidade de parcelas .:");
            parcelas = Convert.ToDecimal (Console.ReadLine());

            Console . Write ( " Informe a Renda Mensal do Cliente: " );
            rendaMensal  = Convert.ToDecimal (Console.ReadLine ());

            credito = emprestimo /parcelas;

           if (credito> ( rendaMensal  * ( decimal ) 0.3))
            {
            Console . WriteLine ("\n Empréstimo negado");

            }
            else
            {
                Console . WriteLine ( "\n Empréstimo aprovado");
            
         }
        }
    }
}
