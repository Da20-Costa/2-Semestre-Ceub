﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo1POO.Model
{
    public class Pessoa
    {
        //Atributos
        public string nome;
        public DateTime dataNascimento;
        public string nomeMae;
        public string nomePai;
        public string cpf;
        public string sexo;
        //Métodos
        public string ImprimirPessoa()
        {
            string resultado;
            resultado = $"CPF: {cpf}\r\nNome: {nome}\r\nSexo: {sexo}\r\nData de Nascimento: {dataNascimento}";
            return resultado;
        }
        public void Inserir()
        {
            Console.WriteLine("Você inseriu um registro.");
        }
        public void Alterar()
        {
            Console.WriteLine("Você alterou um registro.");
        }
    }
}
