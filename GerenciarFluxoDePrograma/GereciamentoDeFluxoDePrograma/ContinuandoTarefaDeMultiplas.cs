using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//Também pode-se optar que somente uma das Tasks finalizem para dar continuidade a execução,
//neste caso é só trocar o WaitAll por WaitAny

namespace GereciamentoDeFluxoDePrograma
{
    class ContinuandoTarefaDeMultiplas
    {
        public static void main(string[]args)
        {

            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 3;
            });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

            Console.ReadKey();

        }
    }
}
