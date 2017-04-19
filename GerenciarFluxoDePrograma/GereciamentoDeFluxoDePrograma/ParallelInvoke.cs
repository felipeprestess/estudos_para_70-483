using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GereciamentoDeFluxoDePrograma
{
    class ParallelInvoke
    {
        /*
         * Mais uma forma de fatiar nossas tarefas e rodar em paralelo é a classe Parallel
         * que fornece paralelismo em funções comuns como o For, Foreach e outros.
         * Mas lembre de usar somente em códigos em que o Loop não será preciso rodar
         * sequencialmente. Ela é indicada para grande volume de tarefas, e se for executada
         * em processos menores o indicado é primeiro fazer um teste de performace.
         */

        //Parallel.Invoke 
        //Executa um conjunto de delegates em paralelo.

        static void Main(string[] args)
        {
            Parallel.Invoke(new Action(Numeros0a9), new Action(Numeros10a19));

            Console.ReadKey();
        }

        public static void Numeros0a9()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        public static void Numeros10a19()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
