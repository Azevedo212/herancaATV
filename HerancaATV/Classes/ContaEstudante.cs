using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaATV.Classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteCheque { get; set; }

        public string Cpf {get; set;}

        public string NomeInstituicao { get; set;}

        public ContaEstudante (int NumConta, string Agencia, string TitularConta, double SaldoConta, 
            double limiteCheque, string cpf, string nomeInstituicao): base(NumConta, Agencia, TitularConta, SaldoConta)
        {
            this.LimiteCheque = limiteCheque;
            this.Cpf = cpf;
            this.NomeInstituicao = nomeInstituicao;
        }
        public ContaEstudante()
        {

        }

        public virtual void Sacar(double saque)
        {
            if(saque <= saldoConta + LimiteCheque)
            {
                saldoConta -= saque;
                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
           
        }




    }
}
