using AppAlugaFacil.Model;

Cliente cliente1 = new Cliente();
Console.WriteLine("Informe o nome do primeiro cliente: ");
cliente1.nome = Console.ReadLine();
Console.WriteLine("Informe o cpf do primeiro cliente: ");
cliente1.cpf = Console.ReadLine();
Console.WriteLine("Informe o número da CNH do primeiro cliente: ");
cliente1.cnh = Console.ReadLine();

Carro carro1 = new Carro();
Console.WriteLine("Informe a placa do primeiro carro: ");
carro1.placa = Console.ReadLine();
Console.WriteLine("Informe o fabricante do primeiro carro: ");
carro1.fabricante = Console.ReadLine();
Console.WriteLine("Informe o modelo do primeiro carro: ");
carro1.modelo = Console.ReadLine();
Console.WriteLine("Informe o ano do primeiro carro: ");
carro1.ano = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a cor do primeiro carro: ");
carro1.cor = Console.ReadLine();
Console.WriteLine("Informe o valor da diária do primeiro carro: ");
carro1.valorDiaria = Convert.ToDouble(Console.ReadLine());

Cliente cliente2 = new Cliente();
Console.WriteLine("Informe o nome do segundo cliente: ");
cliente2.nome = Console.ReadLine();
Console.WriteLine("Informe o cpf do segundo cliente: ");
cliente2.cpf = Console.ReadLine();
Console.WriteLine("Informe o número da CNH do segundo cliente: ");
cliente2.cnh = Console.ReadLine();

Carro carro2 = new Carro();
Console.WriteLine("Informe a placa do segundo carro: ");
carro2.placa = Console.ReadLine();
Console.WriteLine("Informe o fabricante do segundo carro: ");
carro2.fabricante = Console.ReadLine();
Console.WriteLine("Informe o modelo do segundo carro: ");
carro2.modelo = Console.ReadLine();
Console.WriteLine("Informe o ano do segundo carro: ");
carro2.ano = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a cor do segundo carro: ");
carro2.cor = Console.ReadLine();
Console.WriteLine("Informe o valor da diária do segundo carro: ");
carro2.valorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nCliente 1: \n\n" + cliente1.ImprimirCliente() + "\n");
Console.WriteLine("Carro 1: \n\n" + carro1.ImprimirCarro() + "\n");
Console.WriteLine("Cliente 2: \n\n" + cliente2.ImprimirCliente() + "\n");
Console.WriteLine("Carro 2: \n\n" + carro2.ImprimirCarro());