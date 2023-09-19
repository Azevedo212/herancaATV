using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaATV.Classes
{
    internal class Conta
    {
        public int NumConta { get; set; }

        public string Agencia { get; set; }

        public string TitularConta { get; set; }

        public double saldoConta { get; set; }

        public Conta(int numConta, string agencia, string titularConta, double saldoConta)
        {
            this.NumConta = numConta;
            this.Agencia = agencia;
            this.TitularConta = titularConta;
            this.saldoConta = saldoConta;
        }

        public Conta() 
        { 
        
        
        }

        public virtual void Sacar(double saque)
        {
            if(saque <= saldoConta)
            {
                saldoConta -= saque;
                Console.WriteLine("Saque realizado!");
                Console.WriteLine($"R${saque} foram sacados, saldo atualizado: {saldoConta.ToString("c2")} \n");
                
            }
            else
            {
                Console.WriteLine("Saque indisponível, Valor do saque excede ao valor da sua conta!");
            }
            
        }

        public void Depositar(double dep)
        {
            if(dep >= 0)
            {
                saldoConta += dep;
                Console.WriteLine("Saldo após o depósito atualizado: " + saldoConta.ToString("c2") + "\n");
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
            
        }
    }
}
