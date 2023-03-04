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
         public static void Main(string[] args)
        {
            //cadastro usuarios
            //Menu.Criar();
            Usuario u = new Usuario();
            u.Nome = "mota";
            u.Telefone = "45545";
            u.CPF = "54545";
            u.Gravar();

            foreach (Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine("-------CADASTRO DE USUARIOS-------");
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("----------------------------------");
            }

            //cadadastro clientes
            //Menu.Criar();
            Cliente c = new Cliente();
            c.Nome = "marcelo";
            c.Telefone = "45545";
            c.CPF = "54545";
            c.Gravar();

            foreach (Cliente cl in Cliente.LerClientes())
            {
                Console.WriteLine("------CADASTRO DE CLIENTES--------");
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.CPF);
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
