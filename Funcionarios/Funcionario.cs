using System;

namespace curso_csharp.Funcionarios
{
    public abstract class Funcionario
    {
       public Funcionario(String cpf, double salario)
       {
            TotalDeFuncionarios++;
            this.CPF = cpf;
            this.Salario = salario;
        }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        //Tem que implementar nas classes filhas
        public abstract double GetBonificação();

        //Tem que implementar nas classes filhas
        public abstract void AumentarSalario();

        protected void MessangemCricaoConta(string Mensagem)
        {
            Console.WriteLine("Criando o {0}.", Mensagem);
        }  
    }
}