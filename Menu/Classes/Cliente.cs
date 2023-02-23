using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    { 
        public Cliente()
        {
            this.Nome = "danilo";
        }
    
        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {
            //gravar
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDosClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');
                        var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], CPF = clienteArquivo[2] };
                       
                        clientes.Add(cliente);

                    }
                }
            }

            return clientes;
        }
       
    }
}
