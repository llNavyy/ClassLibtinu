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


            

            /*    Produto p = new Produto(txtDescricao.Text, txtUnidade.Text, txtCodbar.Text, txtValor.Text, txtDesconto.Text);
                p.Inserir();
                if (p.Id > 0)
                {
                    txtId.Text = p.Id.ToString();
                    MessageBox.Show("Produto gravado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir produto");
                }
            */

            
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
