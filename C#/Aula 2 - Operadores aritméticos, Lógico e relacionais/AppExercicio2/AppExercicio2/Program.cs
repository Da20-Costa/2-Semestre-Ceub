Int32 numero, sucessor, antecessor;
Console.WriteLine("Informe um número para saber seu sucessor e antecessor: ");
numero = Convert.ToInt32(Console.ReadLine());
sucessor = numero + 1;
antecessor = numero - 1;
Console.WriteLine($"O número {numero} possui o sucessor {sucessor} e o antecessor {antecessor}");
Console.ReadKey();