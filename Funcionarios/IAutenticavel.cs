using System;
using curso_csharp.Sistema;

namespace curso_csharp.Funcionarios
{
    public interface IAutenticavel
    {
        bool Autentificar(string senha);
    }
}
