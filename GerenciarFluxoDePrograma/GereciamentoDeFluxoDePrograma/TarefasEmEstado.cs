using System;
using System.Threading.Tasks;

//O método ContinueWith() também pode receber parâmetros que irão indicar em que situações
//ele irá continuar, como por exemplo se tiver um erro, ou se for processado com sucesso

namespace GereciamentoDeFluxoDePrograma
{
    class TarefasEmEstado
    {
        public static void main(string[] args)
        {
            Task<int> T = Task.Run(() => 
            {
                return 10;
            });

            T.ContinueWith((i) =>
            {
                Console.WriteLine("Cancelado");
            },TaskContinuationOptions.OnlyOnCanceled);

            T.ContinueWith((i) =>
            {
                Console.WriteLine("Erro");
            },TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = T.ContinueWith((i) =>
            {
                Console.WriteLine("Finalizado");
            },TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.ReadKey();
        }
    }
}
