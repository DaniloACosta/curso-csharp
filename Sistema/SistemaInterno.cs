using System;
using curso_csharp.Funcionarios;

namespace curso_csharp.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            if(usuario.Autentificar(senha))
            {
                Console.WriteLine("Seja Bem Vindo!");
                return true;
            }else{
                Console.WriteLine("Login Failed");
                return false;
            }
        }
    }
}       