using System;
using System.Threading.Tasks;

//Uma Task pode ter várias tarefas filha, a tarefa pai finaliza somente quando todas
//as filhas finalizarem.

//O finalTask só roda depois que a tarefa pai finalizar, e a tarefa pai só finaliza 
//depois das tarefas filhas terminarem.

namespace GereciamentoDeFluxoDePrograma
{
    class TarefaFilha
    {
        public static void Main()
        {

            Task<Int32[]> Pai = Task.Run(() =>
            {
                var results = new Int32[3];

                new Task(() => results[0] = 10, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 20, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 30, TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = Pai.ContinueWith(
            parentTask =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });


            finalTask.Wait();
            Console.ReadKey();

        }
    }
}
