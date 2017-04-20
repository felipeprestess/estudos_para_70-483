using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Em Delegates se quisermos chamar mais de uma função, apenas colocamos o operador += à
 * variável do delegate
 */

namespace GereciamentoDeFluxoDePrograma
{ 
    class DelegateMulticast
    {
        delegate void testeMulticast();
        static void Main()
        {
            testeMulticast tm = new testeMulticast(multi1);
            tm += multi2;
            tm();
        }

        private static void multi1()
        {
            Console.WriteLine("Estou no primeiro");
        }

        private static void multi2()
        {
            Console.WriteLine("Estou no segundo");
        }
    }
}
