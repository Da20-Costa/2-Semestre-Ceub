using Exemplo2Polimorfismo.Model;

string tipoAnimal = "";
string resultado = "";
Console.WriteLine($"Selecione o animal: ");
Console.WriteLine("1 - Carneiro\n2 - Gato\n3 - Vaca");
tipoAnimal = Console.ReadLine();

switch (tipoAnimal)
{
    case "1":
        Carneiro carneiro = new Carneiro();
        Console.WriteLine("Informe o nome do animal: ");
        carneiro.Nome = Console.ReadLine();
        resultado = $"O carneiro {carneiro.Nome} tem 4 patas e faz {carneiro.EmitirSom()}";
        Console.WriteLine(resultado);
        break;

    case "2":
        Gato gato = new Gato();
        Console.WriteLine("Informe o nome do animal: ");
        gato.Nome = Console.ReadLine();
        resultado = $"O gato {gato.Nome} tem 4 patas e faz {gato.EmitirSom()}";
        Console.WriteLine(resultado);
        break;

    case "3":
        Vaca vaca = new Vaca();
        Console.WriteLine("Informe o nome do animal: ");
        vaca.Nome = Console.ReadLine();
        resultado = $"A vaca {vaca.Nome} tem 4 patas e faz {vaca.EmitirSom()}";
        Console.WriteLine(resultado);
        break;

    default:
        Console.WriteLine("Insira um número válido");
        break;
}
