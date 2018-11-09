namespace SHOP.UI
{
    partial class pesProduto
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
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.tbPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.lbProcura = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.lbRelatorio = new System.Windows.Forms.Label();
            this.rbEstoque = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 125);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(786, 361);
            this.dgvPesquisa.TabIndex = 21;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(424, 79);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 17;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(424, 56);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 16;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // tbPalavraChave
            // 
            this.tbPalavraChave.Location = new System.Drawing.Point(97, 67);
            this.tbPalavraChave.Name = "tbPalavraChave";
            this.tbPalavraChave.Size = new System.Drawing.Size(321, 20);
            this.tbPalavraChave.TabIndex = 15;
            this.tbPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalavraChave_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Palavra-chave:";
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(564, 62);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 47);
            this.btProcurar.TabIndex = 18;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // lbProcura
            // 
            this.lbProcura.AutoSize = true;
            this.lbProcura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcura.Location = new System.Drawing.Point(244, 9);
            this.lbProcura.Name = "lbProcura";
            this.lbProcura.Size = new System.Drawing.Size(219, 33);
            this.lbProcura.TabIndex = 19;
            this.lbProcura.Text = "Procurar Produtos";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(97, 93);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(321, 21);
            this.cbCategoria.TabIndex = 22;
            this.cbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCategoria_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Categoria:";
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(424, 102);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(55, 17);
            this.rbMarca.TabIndex = 16;
            this.rbMarca.Text = "Marca";
            this.rbMarca.UseVisualStyleBackColor = true;
            this.rbMarca.CheckedChanged += new System.EventHandler(this.rbMarca_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(488, 56);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbCategoria.TabIndex = 16;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btImprimir);
            this.gbRelatorio.Location = new System.Drawing.Point(661, 41);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(135, 78);
            this.gbRelatorio.TabIndex = 41;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Impressão";
            this.gbRelatorio.Visible = false;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(6, 19);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(120, 47);
            this.btImprimir.TabIndex = 27;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.AutoSize = true;
            this.lbRelatorio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelatorio.Location = new System.Drawing.Point(244, 9);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(262, 33);
            this.lbRelatorio.TabIndex = 42;
            this.lbRelatorio.Text = "Relatório de Produtos";
            this.lbRelatorio.Visible = false;
            // 
            // rbEstoque
            // 
            this.rbEstoque.AutoSize = true;
            this.rbEstoque.Location = new System.Drawing.Point(488, 78);
            this.rbEstoque.Name = "rbEstoque";
            this.rbEstoque.Size = new System.Drawing.Size(64, 17);
            this.rbEstoque.TabIndex = 16;
            this.rbEstoque.Text = "Estoque";
            this.rbEstoque.UseVisualStyleBackColor = true;
            this.rbEstoque.CheckedChanged += new System.EventHandler(this.rbEstoque_CheckedChanged);
            // 
            // pesProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.gbRelatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbCategoria);
            this.Controls.Add(this.rbEstoque);
            this.Controls.Add(this.rbMarca);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.tbPalavraChave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.lbProcura);
            this.Controls.Add(this.lbRelatorio);
            this.Name = "pesProduto";
            this.Text = "Procurar Produtos";
            this.Load += new System.EventHandler(this.pesProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.TextBox tbPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.RadioButton rbCategoria;
        public System.Windows.Forms.GroupBox gbRelatorio;
        private System.Windows.Forms.Button btImprimir;
        public System.Windows.Forms.Label lbProcura;
        public System.Windows.Forms.Label lbRelatorio;
        private System.Windows.Forms.RadioButton rbEstoque;
    }
}