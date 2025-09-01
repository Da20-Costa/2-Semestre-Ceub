Int32 numero;
string resultado;

Console.WriteLine("Insira um número: ");
numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{
//    Console.WriteLine("O número é positivo");
//}
//else if (numero < 0) 
//{
//    Console.WriteLine("O número é negativo");
//}
//else
//{
//    Console.WriteLine("O número é igual a 0");
//}

resultado = (numero > 0) ? "O número é positivo" : (numero < 0) ? "O número é negativo" : "O número é igual a 0";
Console.WriteLine(resultado);