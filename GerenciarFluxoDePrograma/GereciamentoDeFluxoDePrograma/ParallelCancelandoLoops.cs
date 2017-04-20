using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * Podemos Cancelar o Loop usando o objeto ParallelLoopState. 
 * Podemos fazer isso usando a opção Break ou Stop. 
 * O break espera as interações que ainda estão rodando terminar, e com o Stop pára tudo
 * e não tem mais conversa. 
 */


namespace GereciamentoDeFluxoDePrograma
{
    class ParallelCancelandoLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio For");

            ParallelLoopResult pFor = Parallel.For(0, 10, (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine(i.ToString());

                if (i >= 5)
                {
                    loopState.Break();
                    Console.WriteLine("Cancelado pelo BREAK");
                }

                Thread.Sleep(1000);
            });


            Console.WriteLine("");
            Console.WriteLine("Início Foreach");

            var numbers = RetornaEnumeravel();

            ParallelLoopResult pForeach = Parallel.ForEach(numbers, (int i, ParallelLoopState loopState) =>
             {
                 Console.WriteLine(i.ToString());

                 if (i >= 5)
                 {
                     loopState.Stop();
                     Console.WriteLine("Cancelado pelo STOP");
                 }

                 Thread.Sleep(1000);
             });

            Console.ReadKey();
        }

        private static IEnumerable<int> RetornaEnumeravel()
        {
            return Enumerable.Range(0, 10);
        }
    }
}
