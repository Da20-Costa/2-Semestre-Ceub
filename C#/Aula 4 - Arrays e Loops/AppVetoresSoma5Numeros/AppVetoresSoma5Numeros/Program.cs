Int32[] numeros = new Int32[5];
Int32 soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Insira o {i+1}° número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    soma += numeros[i];
}

Console.WriteLine($"O resultado da soma dos números inseridos é {soma}");
Console.WriteLine("Os números digitados foram: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}