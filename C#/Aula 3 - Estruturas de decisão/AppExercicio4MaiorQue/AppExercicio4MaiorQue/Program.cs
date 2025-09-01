Int32 numero1, numero2, maiorNumero;

Console.WriteLine("Insira o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O maior número é: ");
maiorNumero = (numero1 > numero2) ? numero1 : numero2;
Console.WriteLine(maiorNumero);