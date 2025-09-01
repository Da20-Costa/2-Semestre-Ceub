Int32[] numerosPares = new Int32[10];
Int32[] numerosImpares = new Int32[10];
Int32 numero;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i + 1}º número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 == 0)
    {
        numerosPares[i] = numero;
    }
    else
    {
        numerosImpares[i] = numero;
    }
}

Console.WriteLine($"\nNúmeros pares:\n");

for (int i = 0;i < 10; i++)
{
    if(numerosPares[i] != 0)
    {
        Console.WriteLine($"{numerosPares[i]}");
    }
}

Console.WriteLine($"\nNúmeros ímpares:\n");

for (int i = 0; i < 10; i++)
{
    if (numerosImpares[i] != 0)
    {
        Console.WriteLine($"{numerosImpares[i]}");
    }
}