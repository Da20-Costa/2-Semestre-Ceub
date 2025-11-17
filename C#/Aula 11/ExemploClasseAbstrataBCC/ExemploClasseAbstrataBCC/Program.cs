using ExemploClasseAbstrataBCC.Model;

Mago mago = new Mago();
Guerreiro guerreiro = new Guerreiro();

Console.WriteLine("Informe o nome do Mago: ");
mago.Nome = Console.ReadLine();
mago.Nivel = 10;
mago.Vida = 5;
Console.WriteLine($"O mago {mago.Nome} que possui {mago.Vida} vidas e está no nível {mago.Nivel}");
mago.UsarHabilidade();

Console.WriteLine("Informe o nome do Guerreiro: ");
guerreiro.Nome = Console.ReadLine();
guerreiro.Nivel = 10;
guerreiro.Vida = 5;
Console.WriteLine($"O guerreiro {guerreiro.Nome} que possui {guerreiro.Vida} vidas e está no nível {guerreiro.Nivel}");
guerreiro.UsarHabilidade();