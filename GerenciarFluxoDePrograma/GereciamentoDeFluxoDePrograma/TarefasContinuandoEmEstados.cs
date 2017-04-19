using System;
using System.Threading.Tasks;

//O método ContinueWith() também pode receber parâmetros que irão indicar em que situações 
//ele irá continuar, como por exemplo se tiver um erro, ou se for processado com sucesso

namespace GereciamentoDeFluxoDePrograma
{
    class TarefasContinuandoEmEstados
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 10;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Cancelado");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Erro");
            },TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i)=>
            {
                Console.WriteLine("Finalizado");
            },TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.ReadKey();
        }
    }
}
