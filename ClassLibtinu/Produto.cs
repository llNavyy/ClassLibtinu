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
        private double unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } }
        public double Unidade { get { return unidade; } }
        public string Codbar { get { return codbar; } }
        public double Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }
        public bool Descontinuado { get { return descontinuado; } }

        // construtores
        public Produto()
        {
        }

        public Produto(string descricao, double unidade, string codbar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
        }
        public Produto(int id, string descricao, double unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        // métodos da Classe

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_inserir";
            cmd.Parameters.AddWithValue("_descricao", descricao);
            cmd.Parameters.AddWithValue("_unidade", unidade);
            cmd.Parameters.AddWithValue("_codbar", codbar);
            cmd.Parameters.AddWithValue("_valor", valor);
            cmd.Parameters.AddWithValue("_desconto", desconto);
            cmd.Parameters.AddWithValue("_descontinuado", descontinuado);


            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static List<Produto> Listar()
        {

            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos order by nome";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                produtos.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    
                    ));

            }
            return produtos;

        }

        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco realiza consulta por Id do produto
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