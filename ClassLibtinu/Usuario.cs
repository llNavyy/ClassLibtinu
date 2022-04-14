using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClassLibtinu
{
    public class Usuario
    {
        // Atributos - "características da classe"
        private int id;
        private string nome;
        private string email;
        private string password;
        private Nivel nivel;
        private bool ativo;


        //propriedades - essas propriedades servem para podermos acessar os atributos da classe de "fora".
        public int Id { get { return id; } set { id = value; } }

        public string Nome { get { return nome; } }

        public string Email { get { return email; } set { email = value; } }
        
        public string Password { get { return password;} }
        public Nivel Nivel { get { return nivel; } }

        public bool Ativo { get { return ativo; } set { ativo = value; } }

       
        //métodos construtores


        public Usuario() //<- Método construtor
        {

        } 

        public Usuario(string nome, string email, string senha, Nivel nivel) // <- Método construtor
        {
            this.nome = nome; // O this aponta para o atributo "nome"
            this.email = email;
            password = senha;
            this.nivel = nivel;
            ativo = true;
           
        }

        public Usuario(int id, string nome, string email, string password, bool ativo, Nivel nivel)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
            this.nivel = nivel;
            
        }



        //métodos da classe

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Password);
            

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

      /*  public static List<Usuario> Listar()
        {

            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuarios.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4)
                   
                    
                    ));

            }
            return usuarios;

        }
      */
        public static bool EfetuarLogin(string email, string senha)
        {
            return false;

        }

    }
}
