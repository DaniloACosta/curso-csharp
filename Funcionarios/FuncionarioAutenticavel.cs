using System;

namespace curso_csharp.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario) : base (cpf, salario)
        {
            base.MessangemCricaoConta("Funcionario Auntenticavel");
        }

        public bool Autentificar(string senha)
        {
            return Senha == senha;
        }
    }
}
