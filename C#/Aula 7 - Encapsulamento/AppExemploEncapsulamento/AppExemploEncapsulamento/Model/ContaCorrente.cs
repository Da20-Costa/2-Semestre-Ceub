﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploEncapsulamento.Model
{
    public class ContaCorrente
    {
        public string numeroConta;
        public string titular;
        private double saldo;
        public double valor;

        public ContaCorrente(string numeroConta, string titular, double saldo)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public string Extrato()
        {
            string resultado = $"Nº Conta: {numeroConta}\nTitular: {titular}\nSaldo: {saldo}";
            return resultado;
        }
    }
}
