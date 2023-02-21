using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Calculo;
using Diretorio;
using Funcoes;
using Genericas;

namespace Tela
{
     class Menu
    {
        public const int SAIR_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "----------MENU DE OPÇÕES-----------" +
                    "\n 0 - SAIR DO PROGRAMA" +
                    "\n 1 - LER ARQUIVOS" +
                    "\n 2 - TABUADA" +
                    "\n 3 - CALCULAR MÉDIA" +
                    "\n ----------------------------------";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIR_PROGRAMA)
                {
                    Environment.Exit(1);
                }

                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine(" ");
                    Arquivo.Ler(1);
                    Console.WriteLine(" ");
                    Opcao.Escolha();
                }

                else if (valor == TABUADA)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite o número da tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine(" ");
                    Opcao.Escolha();
                }

                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("");

                    Media.Aluno();
                    Console.WriteLine(" ");
                    Opcao.Escolha();
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Opção inválida, digite novamente!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Criar();
                }
            }
        }

    }
}
