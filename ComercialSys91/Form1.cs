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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



          /*  //MessageBox.Show("Olá TI91");
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                Usuario usuario = new Usuario("Zé", "zé@gti.com", "123", new Nivel("Caixa", "CX"));
            }
            Cliente cliente = new Cliente();
           
          /*  MessageBox.Show($"Olá {usuario.Nome}!");
            Text = "Sistema Comercial - TI91 " + usuario.Id + " - " + usuario.Nome;
          */


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);
            c.Inserir(c);
            txtId.Text = c.Id.ToString();

        }
    }
}
