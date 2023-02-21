using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;
using Diretorio;
using Funcoes;
using Tela;

namespace Genericas
{
    internal class Opcao
    {
        public static void Escolha()
        {
            Console.WriteLine("Digite (1) para voltar ao menu.");
            Console.WriteLine("Digite qualquer outra tecla para sair.");
            var opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.Clear();
                Menu.Criar();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
