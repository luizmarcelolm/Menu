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
            cliente.Nome = "luiz";
            cliente.Telefone = "455545544";
            cliente.CPF = "45654646";
           
            cliente.Gravar();

            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes) 
            { 
                Console.WriteLine(c.Nome);
            }
            Console.ReadLine();
        }
    }
}
