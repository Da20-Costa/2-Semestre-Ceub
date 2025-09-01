double[] salarios = new double[5];

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Informe o {i+1}º salario: ");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
    if (salarios[i] < 1000)
    {
        salarios[i] *= 1.1;
    }
}

Console.WriteLine("A lista com os valores atualizados é:");

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"{Math.Round(salarios[i], 2)} reais.");
}