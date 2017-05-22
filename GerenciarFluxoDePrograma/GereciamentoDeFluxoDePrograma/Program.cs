using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GereciamentoDeFluxoDePrograma
{
    class Program
    {
        delegate void testeAssincrono(string texto);
        static void main(string[] args)
        {

            testeAssincrono ta = new testeAssincrono(metodoAssync);

            string texto = "ola assincrono";

            ta.BeginInvoke(texto, new AsyncCallback(retornoAssync), "teste");

            Console.ReadKey();
        }


    }
}
