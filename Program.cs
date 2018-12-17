using System;
using curso_csharp.Funcionarios;

namespace curso_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
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
    }
}