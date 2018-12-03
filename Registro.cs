using Herança.Funcionarios;

namespace Herança
{
    public class Registro
    {
        private double _TotalBonificacao;

        public double registrarBonificacao(Funcionario funcionario){
            return _TotalBonificacao += funcionario.GetBonificação();
        }
        
    }   
}