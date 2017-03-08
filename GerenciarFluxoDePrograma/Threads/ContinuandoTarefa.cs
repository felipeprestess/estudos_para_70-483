using System;
using System.Threading;
using System.Threading.Tasks;

//Se quisermos que uma nova tarefa seja executada assim que outra terminar? 
//Usamos o método ContinueWith

//Neste caso a tarefa “T2” só irá começar a executar quando a tarefa “T” finalizar.

namespace Threads
{
    class ContinuandoTarefa
    {
        public static void Main()
        {
            Task<int> T = Task.Run(() => Tarefa());
            Task<int> T2 = T.ContinueWith((i)  =>  Tarefa2(T.Result));
            
            //T.Wait();
            Console.WriteLine(T.Result);
            Console.WriteLine(T2.Result);
         
            Console.ReadKey();
        }

        public static int Tarefa()
        {
            Thread.Sleep(1000);
            return 10;
        }

        public static int Tarefa2(int T1)
        {
            Thread.Sleep(1000);
            return T1 * 2;
        }
    }
}
