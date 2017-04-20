using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Teste com delegate assíncrono
 */

namespace GereciamentoDeFluxoDePrograma
{
    class DelegateAssincrono
    {
        delegate void testeAssincrono(string texto);
        static void Main()
        {
            testeAssincrono ta = new testeAssincrono(metodoAssync);

            string texto = "ola assincrono";

            ta.BeginInvoke(texto, new AsyncCallback(retornoAssync), "teste");

            Console.ReadKey();
        }

        private static void metodoAssync(string texto)
        {
            System.Threading.Thread.Sleep(10000);
        }

        private static void retornoAssync(IAsyncResult i)
        {
            Console.WriteLine(i.AsyncState.ToString());
        }
    }
}
