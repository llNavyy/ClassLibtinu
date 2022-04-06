using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibtinu
{
    public class Usuario
    {
        // Atributos - "características da classe"
        private int id;
        private string nome;
        private string email;
        private string password;
        private bool ativo;

        //propriedades - essas propriedades servem para podermos acessar os atributos da classe de "fora".
        public int Id { get { return id; } set { id = value; } }

        public string Nome { get { return nome; } }

        public string Email { get { return email; } set { email = value; } }
        
        public string Password { get { return password;} }

        public bool Ativo { get { return ativo; } set { ativo = value; } }
        //métodos construtores


        public Usuario() //<- Método construtor
        {

        } 

        public Usuario(string nome, string email, string senha) // <- Método construtor
        {
            this.nome = nome; // O this aponta para o atributo "nome"
            this.email = email;
            password = senha;
            ativo = true;
           
        }

        public Usuario(int id, string nome, string email, string password, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
            
        }



        //métodos da classe

        public int Inserir()
        {
            // Chamadas de banco e gravo o registro
            return id;

        }

        public static bool EfetuarLogin(string email, string senha)
        {
            return false;

        }

    }
}
