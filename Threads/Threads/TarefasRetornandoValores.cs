using System;
using System.Threading;
using System.Threading.Tasks;

//No exemplo não precisamos usar o método T.Wait() para que o código que chamou a task 
//fique aguardando ela esperar, como a task é do tipo que irá ter um retorno a 
//própria CLR entende que deve esperar. Portanto, enquanto a Task não finalizar não teremos
//o seu resultado e o processo ficará parado.

namespace Threads
{
    class TarefasRetornandoValores
    {
        public static void Main()
        {
            Task<int> Tsoma = Task.Run(() => TarefaSoma());
            Task<string> Tdata = Task.Run(() => TarefaDataDeHoje());
            Task<string> T = Task.Run(() => Tarefa());
            //T.Wait();
            Console.WriteLine("Antes");
            Console.WriteLine(Tdata.Result);
            Console.WriteLine(Tsoma.Result);
            Console.WriteLine(T.Result);
            Console.WriteLine("Depois");
            Console.ReadKey();
        }

        static string TarefaDataDeHoje()
        {
            Thread.Sleep(1000);
            return DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        static int TarefaSoma()
        {
            //Thread.Sleep(1000);
            return 2 + 5;
        }

        static string Tarefa()
        {
            Thread.Sleep(1000);
            return "Retorno da tarefa.";
        }
    }
}
