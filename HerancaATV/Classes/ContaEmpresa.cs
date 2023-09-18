using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaATV.Classes
{
    internal class ContaEmpresa:Conta
    {
        public double Taxa_Anuidade {get;set;}

        public double Limite_Emprestimo { get;set;}

        public double Total_Emprestimo { get;set;}

        public ContaEmpresa (int NumConta, string Agencia, string TitularConta, double SaldoConta, double taxa_Anuidade, 
            double limite_Emprestimo, double total_Emprestimo): base(NumConta, Agencia, TitularConta, SaldoConta)            
        {
            Taxa_Anuidade = taxa_Anuidade;
            Limite_Emprestimo = limite_Emprestimo;
            Total_Emprestimo = total_Emprestimo;
        }
      
        public ContaEmpresa()
        {

        }

        public void RealizarEmprestimo(double ValorEmprestimo) 
        {
            if (ValorEmprestimo <= Limite_Emprestimo)
            {
                saldoConta +=  ValorEmprestimo;
                Total_Emprestimo = Limite_Emprestimo - ValorEmprestimo;

                Console.WriteLine($"Empréstimo de R$ {ValorEmprestimo} realizado com sucesso.");
                Console.WriteLine($"Você tem um total de {Total_Emprestimo} de limite");
            }
            else
            {
                Console.WriteLine("Limite excedido");
            }
        }

        public override void Sacar(double valor)
        {
            if(valor > saldoConta)
            {
                Console.WriteLine("valor do saque excede o valor da conta!");
            }

            else if (saldoConta >= 5000)
            {
                valor += 5;
                saldoConta -= valor;
                Console.WriteLine("Saque realizado! foi taxado no valor de R$5,00!");
            }

            else
            {
                saldoConta -= valor;
                Console.WriteLine("Saque realizado!");
            }





        }
    }
}
