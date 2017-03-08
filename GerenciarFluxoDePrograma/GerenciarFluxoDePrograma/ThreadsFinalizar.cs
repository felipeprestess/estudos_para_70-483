using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    //Finalizar uma Thread

    //Pode-se antecipar a finalização de uma thread usando o método Thread.Abort,
    //mas devido a este método ser executado em outra thread, o sistema não tem total
    //controle quando ela será finalizada e também pode ocorrer um travamento do sistema.

    //Portanto, a melhor forma de parar uma thread é usando uma variável onde ambas as threads
    //tenham acesso.

    //Neste exemplo a thread foi iniciada com uma expressão lambda, e depois de iniciada ficou
    //rodando até o valor da variável stop mudasse de valor.

    public static class ThreadsFinalizar
    {
        public static void Main()
        {
            bool stop = false;

            Console.WriteLine("Pressione uma tecla para finalizar");

            Thread t = new Thread(() => 
            {
                while (stop != true)
                {
                    Console.WriteLine("Rodando ...");
                    Thread.Sleep(1000);
                }
            });

            t.Start();

            Console.ReadKey();

            stop = true;
        }
    }
}
