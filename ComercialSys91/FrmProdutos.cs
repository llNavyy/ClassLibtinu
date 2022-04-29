using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibtinu;

namespace ComercialSys91
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto(txtDescricao.Text,
                txtUnidade.Text,
                txtCodbar.Text,
                Double.Parse(txtValor.Text),
                Double.Parse(txtDesconto.Text));

                produto.Inserir();

                txtDescricao.Clear();
                txtUnidade.Clear();
                txtCodbar.Clear();
                txtCodbar.Clear();

                MessageBox.Show("Produto inserido no sistema com sucesso");

            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu uma falha ao inserir o produto no sistema");
            }
            
            

        

            
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProdutos.Rows.Clear();
                List<Produto> listaProdutos = Produto.Listar();

                int cont = 0;

                foreach (Produto produto in listaProdutos)
                {
                    dgvProdutos.Rows.Add();
                    dgvProdutos.Rows[cont].Cells[0].Value = produto.Id.ToString();
                    dgvProdutos.Rows[cont].Cells[1].Value = produto.Codbar.ToString();
                    dgvProdutos.Rows[cont].Cells[2].Value = produto.Valor.ToString();
                    dgvProdutos.Rows[cont].Cells[3].Value = produto.Desconto.ToString();
                    dgvProdutos.Rows[cont].Cells[4].Value = produto.Descricao.ToString();
                    dgvProdutos.Rows[cont].Cells[5].Value = produto.Unidade.ToString();


                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao listar os produtos");
            }
        }
    }
}
