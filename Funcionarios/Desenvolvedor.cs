namespace curso_csharp.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor (string cpf) : base(cpf, 6000)
        {
            base.MessangemCricaoConta("Desenvolvedor");
        }

        public override double GetBonificação()
        {
            return Salario * 1.40;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
    }
}