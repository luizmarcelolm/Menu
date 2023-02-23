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
             cliente.Nome = "mota";
             cliente.Telefone = "2222255555";
             cliente.CPF = "22222222";
             cliente.Gravar();

            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);
            }
            Console.ReadLine();

            //Cliente c = new Cliente();

            // Cliente c2 = new Cliente { Nome = "danilo", Telefone = "44646460", CPF = "654646646"};

            // var l = new List<String>();
        }
    }
}
