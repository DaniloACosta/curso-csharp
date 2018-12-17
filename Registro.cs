using curso_csharp.Funcionarios;

namespace curso_csharp
{
    public class Registro
    {
        private double _TotalBonificacao;

        public double registrarBonificacao(Funcionario funcionario){
            return _TotalBonificacao += funcionario.GetBonificação();
        }

        public double GetBonificação()
        {
            return _TotalBonificacao;
        }
        
    }   
}