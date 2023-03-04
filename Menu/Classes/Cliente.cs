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
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF= cpf;
        }

        public Cliente (int telefone)
        {
            this.Telefone = telefone.ToString();
        }

      
        public string Nome;
        public string Telefone;
        public string CPF;

        public Cliente()
        {
        }
        public void Gravar()
        {
            if (this.GetType() == typeof(Cliente))
            {
                var clientes = Cliente.LerClientes();
                clientes.Add(this);
                if (File.Exists(caminhoBaseClientes()))
                {
                    StreamWriter r = new StreamWriter(caminhoBaseClientes());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Cliente c in clientes)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);
                    }
                    r.Close();
                }
            }
            else
            {
                var usuario= Usuario.LerUsuarios();
                Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
                usuario.Add(u);
                if (File.Exists(caminhoBaseUsuarios()))
                {
                    StreamWriter r = new StreamWriter(caminhoBaseUsuarios());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Usuario c in usuario)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);
                    }
                    r.Close();
                }
            }
        }

            private static string caminhoBaseClientes()
            {
                return ConfigurationManager.AppSettings["BaseDosClientes"];
            }

            private static string caminhoBaseUsuarios()
            {
                return ConfigurationManager.AppSettings["BaseDosUsuarios"];
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
                            {
                              var clienteArquivo = linha.Split(';');
                              var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                              clientes.Add(cliente);
                            }
                       }
                    }
                }

              return clientes;
        }

        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();

            if (File.Exists(caminhoBaseUsuarios()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        {
                            var usuarioArquivo = linha.Split(';');
                            var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }

    }
}
