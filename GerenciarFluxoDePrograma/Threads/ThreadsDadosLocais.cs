using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    //Para dados iniciar dados locais para cada Thread pode ser utilizado a classe ThreadLocal

    //Observe que no código foi usado a classe Thread.CurrentThread
    //isso nos mostra que podemos ter informações da thread que está em execução, 
    //isto é chamado de Thread’s execution contextThread.CurrentThread.
    //Podemos ter informações sobre sua prioridade e outras informações.
    //Se não quisermos que a nossa thread tenha estas informações podemos desabilitar
    //usando o método ExecutionContext.SuppressFlow.

    public static class ThreadsDadosLocais
    {
        public static ThreadLocal<int> field = new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });
        public static void Main()
        {
            Thread t1 = new Thread(Metodo1);
            t1.Start();

            Thread t2 = new Thread(Metodo2);
            t2.Start();

            Console.ReadKey();
        }

        public static void Metodo1()
        {
            for (int i = 0; i < field.Value; i++)
            {
                Console.WriteLine("Thread A: {0}",i);
            }
        }

        public static void Metodo2()
        {
            for (int i = 0; i < field.Value; i++)
            {
                Console.WriteLine("Thread B: {0}", i);
            }
        }
    }
}
