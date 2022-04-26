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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtName.Text, txtSenha.Text, txtEmail.Text);
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show("Usuario gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir usuario");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void listUsuarios_Click(object sender, EventArgs e)
        {
            int cont = 0;
            dgvUsuarios.Rows.Clear();
            List<Usuario> listaDeClientes = Usuario.Listar();
            foreach (Usuario usuario in listaDeClientes)



            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id.ToString();
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome.ToString();
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email.ToString();
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Password.ToString();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Nivel;


                cont++;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
