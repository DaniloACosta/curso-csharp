using System;

namespace Herança.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando o Gerente");
        }
        public override double GetBonificação(){
            return Salario * base.GetBonificação();
        }
    }
}