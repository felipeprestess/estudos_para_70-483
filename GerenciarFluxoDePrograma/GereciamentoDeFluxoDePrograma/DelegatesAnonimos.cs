using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Para utilizar o delegate anônimo, não é necessário criar um método para o delegate,
 * basta apenas atribuir ao parâmetro do delegate
 */

namespace GereciamentoDeFluxoDePrograma
{
    class DelegatesAnonimos
    {
        delegate string testeAnonimo(string nome);
        static void Main()
        {
            string txtMeio = " , estou no meio";
            testeAnonimo ta = delegate (string param)
            {
                param += txtMeio;
                param += " , estou no fim";
                return param;
            };
            Console.WriteLine(ta("Estou no início"));

            string txtMeio2 = " ,estou no meio";
            testeAnonimo ta2 = param =>
            {
                param += txtMeio2;
                param += " , estou no fim";
                return param;
            };
        }

    }
}
