using HerancaATV.Classes;

class Program
{
    static void Main(string[] args)
    {
        Conta c = new Conta(1, "122", "Pedro", 0);

        ContaEmpresa e = new ContaEmpresa();

        e.NumConta = 1;
        e.Agencia = "223";
        e.TitularConta = "Joao";
        e.saldoConta = 50000;
        e.Taxa_Anuidade = 100;
        e.Limite_Emprestimo = 100;
        e.Total_Emprestimo = 0;

        Console.Write("Digite o valor para sacar: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        e.Sacar(valor);

        Console.WriteLine($"Seu saldo atual é de {e.saldoConta}");

        
    }
}