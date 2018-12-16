using System;
using Herança.Funcionarios;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario danilo = new Funcionario("414.891.138-60", 1000);            
            danilo.Nome = "Danilo";
            Console.WriteLine("Bonificação: " + danilo.GetBonificação());
            Console.WriteLine("Nome: {0} - Salário: {1};", danilo.Nome, danilo.Salario);

            Gerente mario = new Gerente("123.456.789-60", 19000);
            mario.Nome = "Francisco";
            Console.WriteLine("Bonificação: " + mario.GetBonificação());
            Console.WriteLine("Nome: {0} - Salário: {1};", mario.Nome, mario.Salario);

            danilo.AumentarSalario();
            mario.AumentarSalario();
            Console.WriteLine("Salário {0} aumentou para {1}.", danilo.Nome, danilo.Salario);
            Console.WriteLine("Salário {0} aumentou para {1}.", mario.Nome, mario.Salario);

            Registro reg = new Registro();
            Console.WriteLine(reg.registrarBonificacao(danilo));
            Console.WriteLine(reg.registrarBonificacao(mario));
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}
