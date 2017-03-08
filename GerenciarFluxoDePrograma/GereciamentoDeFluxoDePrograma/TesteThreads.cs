using System;
using System.Threading;

////A classe Thread pode ser encontrada no NameSpace System.Threading onde podemos criar novas 
//threads, gerenciar suas prioridades e ver os seus status.

//No exemplo vemos o método Main() criando uma nova thread do método MetodoThread() e dando 
//o start. Observe o método t.Join(), a função dele é aguardar enquanto a sua thread 
//não finaliza, ou seja, o código irá ficar aguardando enquanto ela não terminar, 
//podemos observar isso no exemplo que a mensagem “Thread MetodoThread Finalizada.” 
//só foi exibida no console quando ela terminou. Também usamos o método Thread.Sleep(0) 
//para informar o Windows que o ciclo dessa Thread terminou e pode ir para o próximo ciclo, 
//se não colocarmos esse método o windows irá executar toda a primeira thread já que o 
//tempo de execução dela é menor do que o tempo determinado pelo sistema operacional 
//para pausar uma thread e ir para a próxima;

namespace GereciamentoDeFluxoDePrograma
{
    class TesteThreads
    {
        public static void Main()
        {
            Thread t = new Thread(MetodoThread);
            t.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main: {0}",i);
                Thread.Sleep(0);
            }

            Console.WriteLine("Thread Main Finalizada");

            t.Join();//Aguarda até que a thread Main(Principal) seja finalizada

            Console.WriteLine("Thread MetodoThread Finalizada");
            Console.Read();
        }

        public static void MetodoThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Método: {0}",i);
                Thread.Sleep(0);
            }
        }
    }
}
