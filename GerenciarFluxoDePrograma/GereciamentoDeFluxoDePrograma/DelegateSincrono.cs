using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * Teste de Delegate Síncrono
 */

namespace GereciamentoDeFluxoDePrograma
{
    class DelegateSincrono
    {
        public delegate void testeDelegate(string texto);
        static void Main()
        {
            string texto = "delegate síncrono";
            testeDelegate t = new testeDelegate(metodo);
            t.Invoke(texto);
            Console.WriteLine(texto);

            Console.ReadKey();
        }

        private static void metodo(string texto)
        {
            System.Threading.Thread.Sleep(10000);
        }
    }
}
