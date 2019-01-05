using System;

namespace curso_csharp.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            base.MessangemCricaoConta("Diretor");
        }

        public override double GetBonificação()
        {
            return this.Salario * 1.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}