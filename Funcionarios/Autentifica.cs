namespace curso_csharp.Funcionarios
{
    public abstract class Autentifica : Funcionario
    {
        public string Senha { get; set; }

        public Autentifica(string cpf, double salario) : base(cpf, salario)
        {
            
        }

        public bool Autentificado(string senha){
            return Senha == senha; 
        }

    }
}