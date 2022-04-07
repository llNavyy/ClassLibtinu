using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Cliente(string name, string cpf, DateTime dataCad, string email)
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

        public static void Inserir(Cliente cliente)
        {

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
            return new List<Cliente>(); 
            List<Cliente> clientes = new List<Cliente>();


        }

    }
}
