using HerancaATV.Classes;

class Program
{
    static void Main(string[] args)
    { /*
        Conta c = new Conta();       
        c.NumConta = 1;
        c.Agencia = "181";
        c.TitularConta = "fabio";
        c.saldoConta = 700;

        Console.WriteLine(c.saldoConta);

        
        ContaEmpresa e = new ContaEmpresa();

        e.NumConta = 2;
        e.Agencia = "223";
        e.TitularConta = "Joao";
        e.saldoConta = 500;
        e.Taxa_Anuidade = 100;
        e.Limite_Emprestimo = 1000;
        e.Total_Emprestimo = 0;

        Console.Write("Digite o valor para fazer emprestimo: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        e.RealizarEmprestimo(valor);

        Console.WriteLine($"Seu saldo atual é de R${e.saldoConta}");
        */

        ContaEstudante a = new ContaEstudante();

        a.NumConta = 3;
        a.Agencia = "223";
        a.TitularConta = "Pedro";
        a.saldoConta = 500;
        a.LimiteChequeEspecial = 200;
        a.Cpf = "046.321.368-31";

        Console.Write("Digite um valor para sacar: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        a.Sacar(saque);

        Console.WriteLine($"Seu saldo atual é de R${a.saldoConta}");
    }
}