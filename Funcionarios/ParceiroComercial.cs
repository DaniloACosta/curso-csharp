using System;
using System.Collections.Generic;
using System.Text;

namespace curso_csharp.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autentificar(string senha)
        {
            return Senha == senha;
        }
    }
}
