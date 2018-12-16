using System;

namespace Herança.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando o Gerente");
        }
        public override double GetBonificação()
        {
            return Salario * base.GetBonificação();
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}