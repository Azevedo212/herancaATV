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

        public virtual void Sacar(double valor)
        {
            if(valor <= saldoConta)
            {
                saldoConta -= valor;
                Console.WriteLine("Saque realizado!");
                Console.WriteLine($"R${valor} foram sacados, saldo final da conta: R${saldoConta}");
                
            }
            else
            {
                Console.WriteLine("Saque indisponível, Valor do saque excede ao valor da sua conta!");
            }
            
        }

        public void Depositar(double dep)
        {
            saldoConta += dep;
            Console.WriteLine("Valor total após o deposito R$" + saldoConta);
        }
    }
}
