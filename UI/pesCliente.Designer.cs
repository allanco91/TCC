namespace SHOP.UI
{
    partial class pesCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbPesq = new System.Windows.Forms.ComboBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.tbPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.lbProcura = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.rbSimples = new System.Windows.Forms.RadioButton();
            this.rbCompleto = new System.Windows.Forms.RadioButton();
            this.btImprimir = new System.Windows.Forms.Button();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.lbRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Procurar por:";
            // 
            // cbPesq
            // 
            this.cbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq.FormattingEnabled = true;
            this.cbPesq.Location = new System.Drawing.Point(108, 55);
            this.cbPesq.Name = "cbPesq";
            this.cbPesq.Size = new System.Drawing.Size(508, 21);
            this.cbPesq.TabIndex = 30;
            this.cbPesq.SelectionChangeCommitted += new System.EventHandler(this.cbPesq_SelectedIndexChanged);
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(630, 91);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 26;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(630, 68);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 25;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // tbPalavraChave
            // 
            this.tbPalavraChave.Location = new System.Drawing.Point(108, 82);
            this.tbPalavraChave.Name = "tbPalavraChave";
            this.tbPalavraChave.Size = new System.Drawing.Size(508, 20);
            this.tbPalavraChave.TabIndex = 24;
            this.tbPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalavraChave_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Palavra-chave:";
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(697, 68);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 47);
            this.btProcurar.TabIndex = 27;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // lbProcura
            // 
            this.lbProcura.AutoSize = true;
            this.lbProcura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcura.Location = new System.Drawing.Point(299, 9);
            this.lbProcura.Name = "lbProcura";
            this.lbProcura.Size = new System.Drawing.Size(207, 33);
            this.lbProcura.TabIndex = 28;
            this.lbProcura.Text = "Procurar Clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sexo/Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Estado:";
            // 
            // cbCidade
            // 
            this.cbCidade.Enabled = false;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(229, 109);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(194, 21);
            this.cbCidade.TabIndex = 34;
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(108, 108);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(66, 21);
            this.cbEstado.TabIndex = 33;
            this.cbEstado.SelectionChangeCommitted += new System.EventHandler(this.cbEstado_SelectionChangeCommitted);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(495, 108);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 35;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 136);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(1015, 459);
            this.dgvPesquisa.TabIndex = 39;
            // 
            // rbSimples
            // 
            this.rbSimples.AutoSize = true;
            this.rbSimples.Checked = true;
            this.rbSimples.Location = new System.Drawing.Point(21, 34);
            this.rbSimples.Name = "rbSimples";
            this.rbSimples.Size = new System.Drawing.Size(61, 17);
            this.rbSimples.TabIndex = 25;
            this.rbSimples.TabStop = true;
            this.rbSimples.Text = "Simples";
            this.rbSimples.UseVisualStyleBackColor = true;
            // 
            // rbCompleto
            // 
            this.rbCompleto.AutoSize = true;
            this.rbCompleto.Location = new System.Drawing.Point(21, 57);
            this.rbCompleto.Name = "rbCompleto";
            this.rbCompleto.Size = new System.Drawing.Size(69, 17);
            this.rbCompleto.TabIndex = 26;
            this.rbCompleto.Text = "Completo";
            this.rbCompleto.UseVisualStyleBackColor = true;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(96, 34);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(120, 47);
            this.btImprimir.TabIndex = 27;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btImprimir);
            this.gbRelatorio.Controls.Add(this.rbSimples);
            this.gbRelatorio.Controls.Add(this.rbCompleto);
            this.gbRelatorio.Location = new System.Drawing.Point(789, 29);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(238, 100);
            this.gbRelatorio.TabIndex = 40;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Impressão";
            this.gbRelatorio.Visible = false;
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.AutoSize = true;
            this.lbRelatorio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelatorio.Location = new System.Drawing.Point(299, 9);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(216, 33);
            this.lbRelatorio.TabIndex = 41;
            this.lbRelatorio.Text = "Relatório Clientes";
            this.lbRelatorio.Visible = false;
            // 
            // pesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 607);
            this.Controls.Add(this.gbRelatorio);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPesq);
            this.Controls.Add(this.rbInativo);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.tbPalavraChave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.lbProcura);
            this.Controls.Add(this.lbRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Cliente";
            this.Load += new System.EventHandler(this.pesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbRelatorio.ResumeLayout(false);
            this.gbRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPesq;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.TextBox tbPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rbSimples;
        private System.Windows.Forms.RadioButton rbCompleto;
        private System.Windows.Forms.Button btImprimir;
        public System.Windows.Forms.Label lbRelatorio;
        public System.Windows.Forms.Label lbProcura;
        public System.Windows.Forms.GroupBox gbRelatorio;
    }
}