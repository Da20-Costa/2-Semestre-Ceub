double[] salarios = new double[10];
double maiorSalario = 0;

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º salário");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
    if (salarios[i] > maiorSalario)
        maiorSalario = salarios[i];
}

Console.WriteLine($"O maior dos salários digitados é: {maiorSalario}");