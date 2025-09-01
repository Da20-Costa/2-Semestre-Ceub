Int32 idade;
string resultado;

Console.WriteLine("Insira sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    resultado = $"A idade {idade} é maior ou igual a 18 anos";
//}
//else
//{
//    resultado = $"A idade {idade} é menor que 18 anos";
//}

resultado = (idade >= 18) ? $"A idade {idade} é maior ou igual a 18 anos" : $"A idade {idade} é menor que 18 anos";

Console.WriteLine(resultado);