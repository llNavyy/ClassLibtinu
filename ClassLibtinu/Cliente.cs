using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClassLibtinu
{
    public  class Cliente
    {
        //Atributos

        private int id;
        private string nome;
        private string cpf;
        private string email;
    
        private DateTime dataCad;
        private bool ativo;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }

        public string Nome { get { return nome; } set { nome = value; } }

        public string Cpf { get { return cpf; } set { cpf = value; } }

        public string Email { get { return email;} set { email = value; } }

        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }

        public bool Ativo { get { return ativo; } set { ativo = value; } }


        //Construtores
        public Cliente()
        {
        }

        public Cliente(string name, string cpf,  string email)
        {
            Nome = name;
            Cpf = cpf;
            Email = email;
            //DataCad = DateTime.Now;
            // ativo = true;

        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }
        //Métodos da Classe

        public void Inserir(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes(nome, cpf, email, datacad, ativo) " + "values('" + cliente.Nome + "', '" + cliente.Cpf + "', '" + cliente.Email + "', default, default)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@indetity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool Alterar(Cliente cliente)
        {
            return true;
        }

        public static Cliente ConsultarPorId(int _id )
        {
            Cliente cliente = new Cliente();
            return cliente;

        }

        public static Cliente ConsultarPorCPF(string _cpf)
        {
            Cliente cliente = new Cliente();
            return cliente;

           
        }
        public static List<Cliente> Listar()
        {
            
            List<Cliente> clientes = new List<Cliente>();
            return clientes;

        }

    }
}
