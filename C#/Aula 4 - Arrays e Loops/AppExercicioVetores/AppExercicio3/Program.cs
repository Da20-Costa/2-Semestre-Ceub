double[] valoresNumericos = new double[5];
double media = 0;

for (int i = 0; i < valoresNumericos.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º valor: ");
    valoresNumericos[i] = Convert.ToDouble(Console.ReadLine());
    media += valoresNumericos[i] / valoresNumericos.Length;
}

Console.Write($"A média dos números informados é: {Math.Round(media, 2)}");