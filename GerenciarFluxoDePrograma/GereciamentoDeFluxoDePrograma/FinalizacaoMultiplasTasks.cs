using System;
using System.Threading;
using System.Threading.Tasks;

//O método WaitAll serve para aguardar que múltiplas Tasks finalizem
//antes de continuar a execução

namespace GereciamentoDeFluxoDePrograma
{
    class FinalizacaoMultiplasTasks
    {
        public static void Main()
        {

            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine('1');

                return 1;

            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine('2');
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine('3');
                return 3;
            }
            );

            Task.WaitAll(tasks);

            Console.ReadKey();


        }
    }
}
