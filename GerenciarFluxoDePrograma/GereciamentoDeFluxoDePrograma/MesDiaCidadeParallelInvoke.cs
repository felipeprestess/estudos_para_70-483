using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GereciamentoDeFluxoDePrograma
{
    class MesDiaCidadeParallelInvoke
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            Parallel.Invoke(
                new Action(exibirDias),
                new Action(exibirMeses),
                new Action(exibirCidades)
                );

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadKey();
        }

        static void exibirDias()
        {
            string[] diasArray = { "Segunda","Terça","Quarta","Quinta", "Sexta","Sábado", "Domingo" };
            foreach (var dia in diasArray)
            {
                Console.WriteLine($"Dia da semana: {dia}");
                Thread.Sleep(500);
            }
        }

        static void exibirMeses()
        {
            string[] mesArray = { "Jan","Fev","Mar","Abr", "Maio", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
            foreach (var mes in mesArray)
            {
                Console.WriteLine($"Mês: {mes}");
                Thread.Sleep(500);
            }
        }

        static void exibirCidades()
        {
            string[] cidadesArray = { "Londres", "New York", "Paris", "Toquio", "Sidnei", "Brasil" };
            foreach (var cidade in cidadesArray)
            {
                Console.WriteLine($"Cidade: {cidade}");
                Thread.Sleep(500);
            }
        }
    }
}
