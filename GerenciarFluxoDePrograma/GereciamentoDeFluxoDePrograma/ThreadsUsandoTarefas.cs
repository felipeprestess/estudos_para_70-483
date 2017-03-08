using System;
using System.Threading.Tasks;

//Com as Tarefas ou Tasks, temos um controle bem melhor das tarefas 
//que estão sendo executadas, podemos controlar qual tarefa e quando ela irá para 
//o Pool de Threads, diferente das threads que não temos este controle. 
//Podemos deixar outras tarefas aguardando enquanto o processador termina uma fila de tarefas,
//controle que não temos com as threads que vai tudo de uma vez.

//o método T.Wait() é equivalente ao Join da thread que aguarda a finalização da task antes 
//de continuar o código

namespace GereciamentoDeFluxoDePrograma
{
    class ThreadsUsandoTarefas
    {
        public static void Main()
        {
            Task T = Task.Run(() => Tarefa());
            T.Wait();
            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa: {0}", i);
            }
        }
    }
}
