namespace teste_Cep
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRetorna = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtIdDel = new System.Windows.Forms.TextBox();
            this.btnEnde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BAIRRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ENDEREÇO";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(15, 75);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 20);
            this.txtUf.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 122);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(319, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(15, 163);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(172, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 204);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(319, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // pesquisar
            // 
            this.pesquisar.BackColor = System.Drawing.Color.RoyalBlue;
            this.pesquisar.ForeColor = System.Drawing.Color.DarkRed;
            this.pesquisar.Location = new System.Drawing.Point(155, 23);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(71, 23);
            this.pesquisar.TabIndex = 10;
            this.pesquisar.Text = "PESQUISAR";
            this.pesquisar.UseVisualStyleBackColor = false;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(15, 25);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 11;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCep_MaskInputRejected);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.Location = new System.Drawing.Point(248, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(71, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSalvar.Location = new System.Drawing.Point(91, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(222, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnView.ForeColor = System.Drawing.Color.DarkRed;
            this.btnView.Location = new System.Drawing.Point(186, 244);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 23);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRetorna.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRetorna.Location = new System.Drawing.Point(73, 429);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(71, 23);
            this.btnRetorna.TabIndex = 18;
            this.btnRetorna.Text = "RETORNA";
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 273);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(367, 150);
            this.dgv.TabIndex = 19;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Location = new System.Drawing.Point(186, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(71, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtIdDel
            // 
            this.txtIdDel.Location = new System.Drawing.Point(270, 428);
            this.txtIdDel.Name = "txtIdDel";
            this.txtIdDel.Size = new System.Drawing.Size(100, 20);
            this.txtIdDel.TabIndex = 21;
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(270, 230);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(75, 23);
            this.btnEnde.TabIndex = 22;
            this.btnEnde.Text = "PESQUISA";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(382, 499);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.txtIdDel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnRetorna);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRetorna;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtIdDel;
        private System.Windows.Forms.Button btnEnde;
    }
}

