using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibtinu
{
    public class Pedido
    {

        //Podemos criar a classe somente com as propriedades, sem criar os atributos
        //Propriedades

        public int Id { get; set; }

        public DateTime DataPed { get; set; }

        public string Status { get; set; } 

        public double Desconto { get; set; }

        public Cliente Cliente { get; set; }

        public Usuario Usuario { get; set; }

        public List<ItemPedido> Itens { get; set; }


        //Construtores

        public Pedido()
        {

        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        //Métodos da classe / Operações / Ações / Funções

        public void Inserir()
        {

        }

        public bool Alterar(Pedido pedido)
        {
            return false;
        }
        public static Pedido ConsultaPorId(int _id)
        {
            Pedido pedido = new Pedido(); //Conecta no banco e consulta o pedido pelo ID, retornando um objeto pedido.
            return pedido;

        }

        public static List<Pedido> ConsultaPorClienteId(int _id)
        {
            List<Pedido> pedidos= new List<Pedido>(); //Retorna uma lista de pedidos, com base no cliente.

            return pedidos;
        }
    }
}
