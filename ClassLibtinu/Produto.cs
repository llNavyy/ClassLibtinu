using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibtinu
{
    public class Produto
    {
        // atributos da classe
        private int id;
        private string descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } }
        public string Unidade { get { return unidade; } }
        public string Codbar { get { return codbar; } }
        public double Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }
        public bool Descontinuado { get { return descontinuado; } }

        // construtores
        public Produto()
        {
        }

        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
        }
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }


        public Produto( string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = 0;
            this.descontinuado = false;
        }

        // métodos da Classe

        public void Inserir()
        {
            //Método irá inserir no banco de dados na tabela PRODUTOS. Utilizand a procedure, que já foi criada no bando de dados.
            var cmd = Banco.Abrir(); // Podemos utilizar também MySqlCommand cmd = Banco.Abrir(); , lembrando de adicionar a bibilioteca MySql.Data
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtos_inserir";
            cmd.Parameters.AddWithValue("_descricao", descricao);
            cmd.Parameters.AddWithValue("_unidade", unidade);
            cmd.Parameters.AddWithValue("_codbar", codbar);
            cmd.Parameters.AddWithValue("_valor", valor);
         
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

        public static List<Produto> Listar(string descriParte = null)
        {
            //Método irá retornar uma lista com todos os produtos, onde todos serão produtos não descontinuados, ordenados por nome.

            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            if(descriParte == null)
            {
                cmd.CommandText = "select * from produtos where descontinuado = 0 order by 2";
            }
            else
            {//Listará todos os produtos ativos, ordenados por nome, e contendo o termo vindo por parâmetro no método.
                cmd.CommandText = "select * from produtos where descontinuado = 0 and descricao like '%"+descriParte+"%' order by 2";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read()) //Executa um leitura no banco de dados.
            {
                produtos.Add(new Produto( //Adiciona essas "leituras" do BD em uma lista.
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
       
                    ));

            }
            return produtos;  //Retorna essa lista para quem consultou.

        }

        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            // Conectará ao banco e realizará consulta por Id do produto
            return produto;
        }
        public Produto BuscarPorCodBar(string _codBar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produtos
            return produto;
        }
        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta por parte da descriação do produtos
            return produtos;
        }
        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta retornando todos produtos
            return produtos;
        }
        public bool Alterar()
        {
            return true;
        }

    }// fim da classe produto
}