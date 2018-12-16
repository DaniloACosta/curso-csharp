using System;

namespace Herança.Funcionarios
{
    public class Funcionario
    {
       public Funcionario(String cpf, double salario)
       {
            TotalDeFuncionarios++;            
            Console.WriteLine("Criando o Funcionario");
            this.CPF = cpf;
            this.Salario = salario;
        }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }
        public virtual double GetBonificação()
        {
            return Salario * 0.02;
        }

        public virtual void AumentarSalario()
        {
            // this.Salario = this.Salario + (this.Salario  * 0.1);
            // this.Salario = this.Salario * 1.1;
            this.Salario *= 1.1; 
        }   
    }
}