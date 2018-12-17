namespace curso_csharp.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            base.MessangemCricaoConta("Auxiliat");
        }

        public override double GetBonificação()
        {
            return this.Salario * 1.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}