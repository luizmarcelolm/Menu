using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite nota " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do " + nome + " é " + media);
        }
    }
}
