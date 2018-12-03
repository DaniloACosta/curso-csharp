using System;
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

            Gerente francisco = new Gerente("123.456.789-60");

            francisco.Nome = "Francisco";
            francisco.Salario = 19000;
            Console.WriteLine("Bonificação: " + francisco.GetBonificação());

            Registro reg = new Registro();
            Console.WriteLine(reg.registrarBonificacao(danilo));
            Console.WriteLine(reg.registrarBonificacao(francisco));
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}
