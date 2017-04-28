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
            int? ano = null;// uma variável tipo-valor nullable
            var classeAnonima = new { Nome = "George", Idade = 22 };//Uma classe anônima aleatória

            //Aqui um delegate padrão do C# que não retorna valor e aceita de 0 até 16 parâmetros
            Action<int,int> calc = (x,y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(2, 3);

            string txtMeio = ", estou no meio";
            testeAnonimo ta = delegate (string param)
            {
                param += txtMeio;
                param += ", estou no fim";
                return param;
            };
            Console.WriteLine(ta("Estou no início"));

            Console.WriteLine($"Nome: { classeAnonima.Nome}, idade: {classeAnonima.Idade}");

            string txtMeio2 = ", estou no meio";
            testeAnonimo ta2 = param =>
            {
                param += txtMeio2;
                param += ", estou no fim";
                return param;
            };

            //############## Entendendo o uso de eventos ##############
            Jornal J = new Jornal()
            {
                Nome = "Meu Jornal"
            };

            //Assinando o evento
            J.Publicar += MariaLer;
            J.Publicar += JoaoLer;
            J.Publicar += new Jornal.Ler(PedroLer);

            //Invocando evento
            J.PublicarEdicao(1, "Notícia 01");

            //Removendo a assinatura do evento
            J.Publicar -= JoaoLer;
            J.Publicar -= new Jornal.Ler(PedroLer);
            J.PublicarEdicao(2, "Notícia 02");

            Console.Read();           

        }

        static void MariaLer()
        {
            Console.WriteLine("Maria leu.");
        }

        static void JoaoLer()
        {
            Console.WriteLine("João leu.");
        }

        static void PedroLer()
        {
            Console.WriteLine("Pedro leu.");
        }

    }

    class Jornal
    {
        public string Nome { get; set; }
        public delegate void Ler();
        public event Ler Publicar; //Dispara os métodos

        public void PublicarEdicao(int edicao, string texto)
        {
            Console.WriteLine("Edição " + edicao + " publicada");

            Publicar();//Dispara os métodos que assinam o evento
        }
    }

}
