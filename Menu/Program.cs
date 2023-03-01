using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Calculo;
using Classes;
using Diretorio;
using Funcoes;
using Tela;

namespace Console_app
{
    class Program
    { 
        static void Main(string[] args)
        {
            // Menu.Criar();

                            
            var cliente = new Cliente();
            cliente.Nome = "danilo";
            cliente.Telefone = "2222222";
            cliente.CPF = "3333333";
            cliente.Gravar();

            var clientes = Cliente.LerClientes();
            foreach (var c in clientes)
            {
                Console.WriteLine(c.Nome);
            }
            Console.ReadLine();
           
        }
    }
}
