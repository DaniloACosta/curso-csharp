using System;

namespace Herança.Funcionarios
{
    public class Funcionario
    {
       public Funcionario(String cpf){
            TotalDeFuncionarios++;            
            Console.WriteLine("Criando o Funcionario");
            this.CPF = cpf;
        }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }
        public virtual double GetBonificação(){
            return Salario * 0.02;
        }      
    }
}