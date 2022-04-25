﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys91
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar instância do formulário cliente
            FrmCliente frmCliente = new FrmCliente();
            //Tornando FrmCliente filho do Container FrmPrincipal
            frmCliente.MdiParent = this;

            //Irá exibir o formuçário cliente
            frmCliente.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
