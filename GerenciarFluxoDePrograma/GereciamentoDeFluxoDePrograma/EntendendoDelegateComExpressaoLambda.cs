using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 *Aqui está sendo utilizado o delegate com expressão lambda
 */

namespace GereciamentoDeFluxoDePrograma
{
    class EntendendoDelegateComExpressaoLambda
    {
        public delegate int Calcular(int x, int y);
        static void Main(string[] args)
        {
            Calcular calc = (x, y) => x * y;
            Console.WriteLine("Resultado da Multiplicação");
            Console.WriteLine(calc(3, 4));

            calc = (x, y) =>
            {
                Console.WriteLine("Resultado da Soma");
                return x + y;
            };

            Console.WriteLine(calc(3, 4));

            Console.ReadKey();
        }

    }
}
