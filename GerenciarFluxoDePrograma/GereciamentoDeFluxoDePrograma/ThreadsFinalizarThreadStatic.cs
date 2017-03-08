using System;
using System.Threading;

//Podemos marcar um campo com o atributo [ThreadStatic], isso faz com que cada thread
//tenha uma cópia do campo, e não um valor global para todas. Se o atributo [ThreadStatic] 
//for removido o que for modificado em uma thread será visto pelas outras.

namespace GereciamentoDeFluxoDePrograma
{
    class ThreadsFinalizarThreadStatic
    {
        [ThreadStatic]
        public static int num;
        public static void Main()
        {
            Console.WriteLine("Thread: {0}",num);

            new Thread(()=> 
            {
                for (int i = 0; i < 10; i++)
                {
                    num++;
                    Console.WriteLine("Thread A: {0}", num);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    num++;
                    Console.WriteLine("Thread B: {0}", num);
                }
            }).Start();

            Console.WriteLine("Thread: {0}",num);
            Console.ReadKey();
        }


    }
}
