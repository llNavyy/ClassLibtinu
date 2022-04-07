using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassLibtinu
{
    //Documentação de classes de projeto. - XML Docs



    //Atributos 
    public class Produto
    {
        private int id;
        private string descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;


        //Propriedades
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }

        private string Unidade { get { return unidade; } set { unidade = value; } }

        private string Codbar { get { return codbar; } }

        private double Valor { get { return valor; } set { valor = value; } }
        
        private double Desconto { get { return desconto; } set { desconto = value; } }


        //Construtores

        Produto()
        {

        }

        public Produto(string descricao, string unidade, double valor, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            Valor = valor;
            Desconto = desconto;
        }

        public Produto(string descricao, string unidade, double valor)
        {
            Descricao = descricao;
            Unidade = unidade;
            Valor = valor;
        }

        //Métodos

        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            return produto;

            //Este método cria uma instância do produto que será retornado, ao ser chamado com o parâmetro passado "ID".

        }

        public static Produto ConsultarPorCodBar(int _codBar)
        {
            Produto produto = new Produto();
            return produto;

            //Este método cria uma instância do produto que será retornado, ao ser chamado com o parâmetro codBar.

        }

        public static List<Produto> ListaProduto(string _descricao)
        {
            
            List<Produto> produtos = new List<Produto>();
            return produtos;//Este método apresentará uma lista de produtos, ao ser chamado com o parâmetro "descricao"
        }
    }
}
