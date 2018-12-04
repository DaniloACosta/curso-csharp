﻿using System;
using Herança.Funcionarios;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario danilo = new Funcionario("414.891.138-60");
            
            danilo.Nome = "Danilo";
            danilo.Salario = 1000;
            Console.WriteLine("Bonificação: " + danilo.GetBonificação());

            Gerente mario = new Gerente("123.456.789-60");

            mario.Nome = "Francisco";
            mario.Salario = 19000;
            Console.WriteLine("Bonificação: " + mario.GetBonificação());

            Registro reg = new Registro();
            Console.WriteLine(reg.registrarBonificacao(danilo));
            Console.WriteLine(reg.registrarBonificacao(mario));
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}
