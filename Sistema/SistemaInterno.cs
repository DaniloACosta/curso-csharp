using System;
using curso_csharp.Funcionarios;

namespace curso_csharp.Sistema
{
    public class SistemaInterno
    {
        public void Logar(Autentifica usuario, string senha)
        {
            if(usuario.Autentificado(senha))
            {
                Console.WriteLine("Seja Bem Vindo!");
            }else{
                Console.WriteLine("Login Failed");
            }
        }
    }
}