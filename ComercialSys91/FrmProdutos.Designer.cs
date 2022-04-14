namespace ComercialSys91
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtCodbar = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codbar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desconto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(400, 87);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 22);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(400, 160);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 22);
            this.txtUnidade.TabIndex = 6;
            // 
            // txtCodbar
            // 
            this.txtCodbar.Location = new System.Drawing.Point(400, 218);
            this.txtCodbar.Name = "txtCodbar";
            this.txtCodbar.Size = new System.Drawing.Size(100, 22);
            this.txtCodbar.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(400, 286);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 8;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(400, 335);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(0, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(368, 400);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 10;
            this.btnInsere.Text = "button1";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(400, 47);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(43, 22);
            this.txtId.TabIndex = 11;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodbar);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtCodbar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.TextBox txtId;
    }
}