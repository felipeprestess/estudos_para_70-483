using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
   Mas quando usar delegates? Pesquisando por aí veremos vários motivos como:

    1.Quando queremos passar um método como parâmetro;
    2.Quando queremos encapsular um método;
    3.Executar vários métodos com somente uma chamada;
    4.Criar algorítimos flexível e reutilizável.
    5.Quando ainda não sabemos o método que vamos chamar mas precisamos chamá-lo em tempo de execução.
*/

namespace GereciamentoDeFluxoDePrograma
{
    class EntendendoDelegate
    {

        public delegate string MetodoDelegate(int numero);

        static void Main(string[] args)
        {
            //1ª forma de instânciar o delegate
            MetodoDelegate oMD = RetornoValor;
            Console.WriteLine($"1ª forma, valor: {oMD(1)}");

            //2ª forma de instanciar o delegate
            MetodoDelegate oMD2 = new MetodoDelegate(RetornoValor);
            Console.WriteLine($"2ª forma, valor: {oMD2(2)}");

            //3ª forma de instanciar o delegate´com método anônimo
            MetodoDelegate oMD3 = delegate (int numero)
            {
                return numero.ToString();
            };
            Console.WriteLine($"3ª forma, valor: {oMD3(3)}");

            //4ª forma de instanciar o delegate com expressão lambda
            MetodoDelegate oMD4 = d => d.ToString();
            Console.WriteLine($"4ª forma, valor: {oMD4(4)}");
        }

        static string RetornoValor(int numero)
        {
            return numero.ToString();
        }
    }
}
