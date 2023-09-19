using HerancaATV.Classes;

class Program
{
    static List<Conta> contas = new List<Conta>();
    static void Main(string[] args)
    {
        int nConta = 1;

        while (true)
        {
            Conta conta = new Conta();
            Console.WriteLine("-------------------------");
            Console.WriteLine("BANCO");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n1 - Criar conta normal \n2- Criar Conta empresarial \n3- Criar conta Estudante \n");
            Console.Write("Digite a opção que deseja: ");
            int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            switch(opcaoEscolhida)
            {
                case 1:
                    Conta n = new Conta();
                    nConta += 1;

                    Console.Write("Agência: ");
                    n.Agencia = Console.ReadLine();      

                    Console.Write("Titular da conta: ");
                    n.TitularConta = Console.ReadLine();

                    Console.Write("Saldo Inicial: ");
                    n.saldoConta = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n-----------------------------------");
                    Console.WriteLine("Conta criada Com sucesso!!!");
                    Console.WriteLine("------------------------------------\n");

                    while (true)
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("OPERAÇÕES");
                        Console.WriteLine("-----------------");


                        Console.WriteLine("1 - Sacar");
                        Console.WriteLine("2 - Depósitar");
                        Console.WriteLine("3 - Sair \n");
                        Console.Write("Qual operação deseja fazer: ");
                        int opcao = Convert.ToInt32(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o valor do saque: ");
                                int saque = Convert.ToInt32(Console.ReadLine());
                                n.Sacar(saque);          
                                break;
                            case 2:
                                Console.Write("Digite o valor do depósito: ");
                                int deposito = Convert.ToInt32(Console.ReadLine());
                                n.Depositar(deposito);
                                break;
                            case 3:
                                Console.Clear();
                                goto exit1;
                            default:
                                Console.WriteLine("Numero inválido!");
                                break;

                        }
                    }
                exit1:;
                     break;

                case 2:
                    ContaEmpresa c = new ContaEmpresa();
                    nConta += 1;

          
                    Console.Write("Agência: ");
                    c.Agencia = Console.ReadLine();

                    Console.Write("Titular da conta: ");
                    c.TitularConta = Console.ReadLine();

                    Console.Write("Saldo Inicial: ");
                    c.saldoConta = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Taxa anuidade: ");
                    c.Taxa_Anuidade = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Limite de empréstimo: ");
                    c.Limite_Emprestimo = Convert.ToDouble(Console.ReadLine());

                    c.Total_Emprestimo = 0;

                    Console.WriteLine("\n-----------------------------------");
                    Console.WriteLine("Conta criada Com sucesso!!!");
                    Console.WriteLine("------------------------------------\n");

                
                    while(true)
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("OPERAÇÕES");
                        Console.WriteLine("-----------------");

                        Console.WriteLine("1 - Empréstimo");
                        Console.WriteLine("2 - Saque");
                        Console.WriteLine("3 - Depósito");
                        Console.WriteLine("4 - Sair \n");
                        Console.Write("Qual operação deseja fazer: ");


                        int opcao = Convert.ToInt32(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o valor do empréstimo: ");
                                int emprestimo = Convert.ToInt32(Console.ReadLine());
                                c.RealizarEmprestimo(emprestimo);
                                break;

                            case 2:
                                Console.Write("Digite o valor do saque: ");
                                int saque = Convert.ToInt32(Console.ReadLine());
                                c.Sacar(saque);                         
                                break;

                            case 3:
                                Console.Write("Digite o valor do depósito: ");
                                int deposito = Convert.ToInt32(Console.ReadLine());
                                c.Depositar(deposito);
                                break;

                            case 4:
                                Console.Clear();
                                goto sair;
                                

                            default:
                                Console.WriteLine("número inválido! \n");
                                break;

                        }
                    }
                sair:;    
                    break;


                case 3:
                    ContaEstudante estudante = new ContaEstudante();
                    nConta += 1;
         
                    Console.Write("Agência: ");
                    estudante.Agencia = Console.ReadLine();

                    Console.Write("Titular da conta: ");
                    estudante.TitularConta = Console.ReadLine();

                    Console.Write("Saldo Inicial: ");
                    estudante.saldoConta = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Limite do cheque especial: ");
                    estudante.LimiteCheque = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Cpf: ");
                    estudante.Cpf = Console.ReadLine();

                    Console.WriteLine("\n-----------------------------------");
                    Console.WriteLine("Conta criada Com sucesso!!!");
                    Console.WriteLine("------------------------------------\n");

                    while(true)
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("OPERAÇÕES");
                        Console.WriteLine("-----------------");
             
                        Console.WriteLine("1 - Saque");
                        Console.WriteLine("2 - Depósito");
                        Console.WriteLine("3 - Sair \n");
                        Console.Write("Qual operação deseja fazer: ");
                        int opcao = Convert.ToInt32(Console.ReadLine());

                        switch(opcao)
                        {
                            case 1: 
                                Console.Write("Digite o valor do saque: ");
                                int saque = Convert.ToInt32(Console.ReadLine());
                                estudante.Sacar(saque);
                                break;
                            case 2:
                                Console.Write("Digite o valor do depósito: ");
                                int deposito = Convert.ToInt32(Console.ReadLine());
                                estudante.Depositar(deposito);
                                break;
                            case 3:
                                Console.Clear();
                                goto exit;

                            default:
                                Console.WriteLine("Opção inválida!!! \n");
                                break;
                                
                        }
                    }
                exit:;
                    break;  
            }
        }
    }
}