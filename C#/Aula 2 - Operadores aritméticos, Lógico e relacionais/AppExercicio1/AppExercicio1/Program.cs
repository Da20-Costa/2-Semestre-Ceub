﻿string nome, endereco, telefone, resultado;
Console.WriteLine("Informe o seu nome: ");

nome = Console.ReadLine();
Console.WriteLine("Informe o seu endereço: ");
endereco = Console.ReadLine();

Console.WriteLine("Informe o seu telefone: ");
telefone = Console.ReadLine();

resultado = $"Nome: {nome}\r\nEndereço: {endereco}\r\nTelefone: {telefone}";
Console.WriteLine(resultado);