using System;
using System.Threading;

//Outra propriedade importante de uma Thread é se ela é ForeGround ou BackGround, 
//se ela for Foreground isso significa que ela não depende de outras threads para 
//continuar sua execução e mantem a aplicação ativa, mas se for BackGround ela só
//continuará a ser executada enquanto ainda tivermos uma thread ForeGround rodando, 
//se não tiver, a aplicação é finalizada mesmo com threads do tipo Background ativa.

//A thread do método “MetodoThread” é do tipo Background (t.IsBackground = true; ) 
//isso quer dizer que ela precisa que a thread do método Main que é do tipo padrão 
//ForeGround continue rodando para que ela continue a existir, mas no exato momento 
//em que a thread do método Main finaliza a Thread do método “MetodoThread” também 
//finaliza mesmo não terminando o que tinha que fazer. 
//Se você rodar a aplicação novamente com o atributo IsBackground com valor de false 
//irá ver que desta vez toda a thread será executada.

namespace GereciamentoDeFluxoDePrograma
{
    class ThreadForegroundBackground
    {
        public static void Main()
        {
            Thread t = new Thread(MetodoThread);
            t.IsBackground = true;//torna a thread background, dependendo da thread foreground (Principal)
            t.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main: {0}",i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread Main Finalizada");
        }

        public static void MetodoThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Metodo: {0}",i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread MetodoThread Finaliza");
            Console.Read();
        }
    }
}
