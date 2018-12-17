using System;

namespace curso_csharp.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
            base.MessangemCricaoConta("Gerente de Conta");
        }
        public override double GetBonificação()
        {
            return Salario * 1.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}