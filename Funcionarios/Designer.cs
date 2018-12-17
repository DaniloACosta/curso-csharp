namespace curso_csharp.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
            base.MessangemCricaoConta("Designer");
        }

        public override double GetBonificação()
        {
            return this.Salario * 1.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11; 
        }
    }
}