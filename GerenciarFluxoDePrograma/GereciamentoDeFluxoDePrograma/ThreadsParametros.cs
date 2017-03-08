using System;
using System.Threading;

//Enviando parâmetros para a Thread

//Também podemos passar parâmetros para a thread que criamos, instanciando ela como
//ParameterizedThreadStart e passando o parâmetro pelo método “Start”.

//Observe que o valor 10 é enviado para o método novaThread como um objeto e 
//pode converter para o tipo desejado.

namespace GereciamentoDeFluxoDePrograma
{
    class ThreadsParametros
    {
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(novaThread));
            t.Start(10);
            Console.Read();
        }

        public static void novaThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("valor: {0}", i);
            }
        }
    }
}
