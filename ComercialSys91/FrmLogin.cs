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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text)){
                this.Close();
            }
            else
            {
                lblMensagem.Text = "Email ou senha incorreta";
            }
        }
    }
}
