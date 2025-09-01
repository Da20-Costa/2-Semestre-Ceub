Int32 numeroEstacao;

Console.WriteLine("Informe um número para a estação:\n1-Primavera\n2-Verão\n3-Outono\n4-Inverno");
numeroEstacao = Convert.ToInt32(Console.ReadLine());

switch (numeroEstacao)
{
    case 1:
        Console.WriteLine("A estação escolhida é Primavera");
        break;
    case 2:
        Console.WriteLine("A estação escolhida é Verão");
        break;
    case 3:
        Console.WriteLine("A estação escolhida é Outono");
        break;
    case 4:
        Console.WriteLine("A estação escolhida é Inverno");
        break;
    default:
        Console.WriteLine("Estação Inválida");
        break;
}
