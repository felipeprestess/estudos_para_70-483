using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 * 
 * Mais uma forma de fatiar nossas tarefas e rodar em paralelo é a classe Parallel 
 * que fornece paralelismo em funções comuns como o For, Foreach e outros. 
 * Mas lembre de usar somente em códigos em que o Loop não será preciso rodar
 * sequencialmente. Ela é indicada para grande volume de tarefas, e se for executada
 * em processos menores o indicado é primeiro fazer um teste de performace.
 * 
    Parallel.For
    Realiza o paralelismo equivalente ao Loop FOR em C#

    Parallel.ForEach
    Realiza o paralelismo equivalente ao Loop FOREACH em C#
*/
namespace GereciamentoDeFluxoDePrograma
{
    class ParallelForEForeach
    {
        static void Main()
        {
            Console.WriteLine("FOR");

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            });

            Console.WriteLine("FOREACH");

            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            });

            Console.ReadKey();
        }
    }
}
