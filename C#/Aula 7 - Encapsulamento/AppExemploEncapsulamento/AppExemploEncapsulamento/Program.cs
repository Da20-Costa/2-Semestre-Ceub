﻿using AppExemploEncapsulamento.Model;

ContaCorrente contaCorrente = new ContaCorrente(3000);
Console.WriteLine("Informe o número da Conta Corrente");
contaCorrente.numeroConta = Console.ReadLine();
Console.WriteLine("Informe o titular da Conta Corrente");
contaCorrente.titular = Console.ReadLine();
Console.WriteLine("Informe o valor do saque da Conta Corrente");
double valor = Convert.ToDouble(Console.ReadLine());
contaCorrente.Sacar(valor);
//contaCorrente.saldo = 3000;

string resultado = contaCorrente.Extrato();
Console.WriteLine(resultado);
