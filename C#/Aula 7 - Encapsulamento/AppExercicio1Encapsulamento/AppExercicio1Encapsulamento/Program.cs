using AppExercicio1Encapsulamento.Model;

Funcionario funcionario = new Funcionario();
Console.WriteLine("Informe o nome do Funcionário: ");
funcionario.Nome = Console.ReadLine();
Console.WriteLine("Informe a data de nascimento do Funcionário: ");
funcionario.DataNascimento = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Informe o salário do Funcionário: ");
funcionario.Salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o número de filhos do Funcionário: ");
funcionario.NumeroFilhos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a área de atuação do Funcionário: ");
funcionario.AreaAtuacao = Console.ReadLine();
string resultado = $"Nome: {funcionario.Nome}\nData de Nascimento: {funcionario.DataNascimento}\n" +
    $"Salário: {funcionario.Salario}\nNº de filhos: {funcionario.NumeroFilhos}\nÁrea de atuação: {funcionario.AreaAtuacao}";
Console.WriteLine(resultado);