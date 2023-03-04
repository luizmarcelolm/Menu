using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Tela;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {

            Console.WriteLine("-------------- CADASTRO DE CLIENTES ----------------\n");

            while (true)
            {
                   string mensagem = "Digite uma opção a baixo" +
                   "\n 0 - CADASTRAR NOVO CLIENTE" +
                   "\n 1 - LISTAR CLIENTES" +
                   "\n 2 - VOLTAR AO MENU" +
                   "\n 3 - SAIR DO CADASTRO" +
                   "\n ----------------------------------";
                   Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == 2)
                {
                    Console.Clear();
                    Menu.Criar();
                    
                }
                //encerrar programa
                if (valor == 3)
                {
                    Environment.Exit(1);
                }
                //cadastrar clientes
                else if (valor == 0)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do cliente");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o cpf do cliente");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                //listar clientes
                else if(valor == 1) { }
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);
                        Console.WriteLine("-------------");
                    }
                    
                }
                Console.WriteLine("Tecle ententer para continuar...");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
