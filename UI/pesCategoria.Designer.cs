namespace SHOP.UI
{
    partial class pesCategoria
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
            this.lbProcura = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPalavraChave = new System.Windows.Forms.TextBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.lbRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProcura
            // 
            this.lbProcura.AutoSize = true;
            this.lbProcura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcura.Location = new System.Drawing.Point(164, 10);
            this.lbProcura.Name = "lbProcura";
            this.lbProcura.Size = new System.Drawing.Size(236, 33);
            this.lbProcura.TabIndex = 8;
            this.lbProcura.Text = "Procurar Categorias";
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(421, 46);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 40);
            this.btProcurar.TabIndex = 3;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palavra-chave:";
            // 
            // tbPalavraChave
            // 
            this.tbPalavraChave.Location = new System.Drawing.Point(97, 56);
            this.tbPalavraChave.Name = "tbPalavraChave";
            this.tbPalavraChave.Size = new System.Drawing.Size(254, 20);
            this.tbPalavraChave.TabIndex = 0;
            this.tbPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalavraChave_KeyPress);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(357, 46);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Checked = true;
            this.rbTipo.Location = new System.Drawing.Point(357, 69);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(46, 17);
            this.rbTipo.TabIndex = 2;
            this.rbTipo.TabStop = true;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(15, 92);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(600, 270);
            this.dgvPesquisa.TabIndex = 14;
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btImprimir);
            this.gbRelatorio.Location = new System.Drawing.Point(502, 8);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(113, 78);
            this.gbRelatorio.TabIndex = 42;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Impressão";
            this.gbRelatorio.Visible = false;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(6, 19);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(101, 47);
            this.btImprimir.TabIndex = 27;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.AutoSize = true;
            this.lbRelatorio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelatorio.Location = new System.Drawing.Point(164, 10);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(245, 33);
            this.lbRelatorio.TabIndex = 43;
            this.lbRelatorio.Text = "Relatório Categorias";
            this.lbRelatorio.Visible = false;
            // 
            // pesCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 373);
            this.Controls.Add(this.gbRelatorio);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.rbTipo);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.tbPalavraChave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.lbProcura);
            this.Controls.Add(this.lbRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pesCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPalavraChave;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        public System.Windows.Forms.Label lbProcura;
        public System.Windows.Forms.GroupBox gbRelatorio;
        private System.Windows.Forms.Button btImprimir;
        public System.Windows.Forms.Label lbRelatorio;
    }
}