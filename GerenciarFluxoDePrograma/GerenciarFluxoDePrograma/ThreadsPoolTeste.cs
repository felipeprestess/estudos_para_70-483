using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    //Thread Pools (Coleções de Threads)

    //Criar Threads uma por uma consome tempo e recursos do nosso ambiente e quando
    //finalizamos uma thread ela simplesmente deixa de existir. 
    //Para que isso não aconteça podemos criar um Thread Pool que tem a finalidade de aproveitar
    //threads que não vamos mais usar, evitando o tempo e recurso que usaríamos criando uma nova. Portanto, em vez de deixar uma thread morrer, enviamos ela para o Thread Pool para que possa ser reutilizada.

    //O Thread Pool gerencia automaticamente a quantidade de threads que ele precisa manter, 
    //e decide se vai criar uma nova thread ou vai alocar uma nova tarefa a uma thread 
    //já existente
    public static class ThreadsPoolTeste
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MetodoRetorno));
            Console.ReadKey();
        }

        static void MetodoRetorno(Object stateInfo)
        {
            Console.WriteLine("Trabalhando com uma ThreadPool");
        }
    }
}
