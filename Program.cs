using System;
using curso_csharp.Funcionarios;
using curso_csharp.Sistema;

namespace curso_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadKey();

        //public abstract class Casa
        //{

        //    public abstract void AbrirPorta();

        //}

        //public interface Carro
        //{
        //    void AbrirPorta();
        //}

        //public class Exemplo : Casa, Carro
        //{
        //    public override void AbrirPorta()
        //    {

        //    }
        }



        public static void CalcularBonificacao()
        {
            Registro reg = new Registro();

            Auxiliar charles = new Auxiliar("123.456.789-60");
            Designer saltiago = new Designer("789.456.123.80");
            Diretor diaz = new Diretor("147.258.369-10");
            GerenteDeConta jake = new GerenteDeConta("369.258.147-50");
            Desenvolvedor dany = new Desenvolvedor("159478236-60");

            reg.registrarBonificacao(charles);
            reg.registrarBonificacao(dany);
            reg.registrarBonificacao(saltiago);
            reg.registrarBonificacao(diaz);
            reg.registrarBonificacao(jake);

            Console.WriteLine("O custo total gasto com bonificação foi R$ {0}", string.Format("{0:0,0.00}", reg.GetBonificação()));
        }

        public static void UsarSistema()
        {
            Diretor diaz = new Diretor("147.258.369-10");
            diaz.Senha = "123";

            SistemaInterno entrarSistema = new SistemaInterno();
            entrarSistema.Logar(diaz, "123");

            ParceiroComercial Terry = new ParceiroComercial();
            Terry.Senha = "159";
            entrarSistema.Logar(Terry, "159");

        }
    }
}