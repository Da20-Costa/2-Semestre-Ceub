using AppGerenciamentoFinanceiro.Model;

ContaCorrente contaCorrente = new ContaCorrente();

Console.WriteLine("Qual o nome do cliente?");
contaCorrente.nomeCliente = Console.ReadLine();
Console.WriteLine("Qual o nome do banco?");
contaCorrente.nomeBanco = Console.ReadLine();
Console.WriteLine("Qual o nome da agência?");
contaCorrente.nomeAgencia = Console.ReadLine();
Console.WriteLine("Qual o número da conta?");
contaCorrente.numeroConta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine(contaCorrente.ImprimirConta());