namespace SHOP.UI
{
    partial class pesPedido
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
            this.tbPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.lbProcura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPesq = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPagAberto = new System.Windows.Forms.RadioButton();
            this.rbPagEfetuado = new System.Windows.Forms.RadioButton();
            this.rbPagTodos = new System.Windows.Forms.RadioButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.lbRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPalavraChave
            // 
            this.tbPalavraChave.Location = new System.Drawing.Point(97, 77);
            this.tbPalavraChave.Name = "tbPalavraChave";
            this.tbPalavraChave.Size = new System.Drawing.Size(560, 20);
            this.tbPalavraChave.TabIndex = 30;
            this.tbPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalavraChave_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Palavra-chave:";
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(663, 50);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 74);
            this.btProcurar.TabIndex = 31;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // lbProcura
            // 
            this.lbProcura.AutoSize = true;
            this.lbProcura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcura.Location = new System.Drawing.Point(277, 9);
            this.lbProcura.Name = "lbProcura";
            this.lbProcura.Size = new System.Drawing.Size(206, 33);
            this.lbProcura.TabIndex = 32;
            this.lbProcura.Text = "Procurar Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Procurar por:";
            // 
            // cbPesq
            // 
            this.cbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq.FormattingEnabled = true;
            this.cbPesq.Location = new System.Drawing.Point(97, 50);
            this.cbPesq.Name = "cbPesq";
            this.cbPesq.Size = new System.Drawing.Size(560, 21);
            this.cbPesq.TabIndex = 34;
            this.cbPesq.SelectionChangeCommitted += new System.EventHandler(this.cbPesq_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Pagamento:";
            // 
            // rbPagAberto
            // 
            this.rbPagAberto.AutoSize = true;
            this.rbPagAberto.Enabled = false;
            this.rbPagAberto.Location = new System.Drawing.Point(330, 105);
            this.rbPagAberto.Name = "rbPagAberto";
            this.rbPagAberto.Size = new System.Drawing.Size(73, 17);
            this.rbPagAberto.TabIndex = 39;
            this.rbPagAberto.Text = "Em aberto";
            this.rbPagAberto.UseVisualStyleBackColor = true;
            // 
            // rbPagEfetuado
            // 
            this.rbPagEfetuado.AutoSize = true;
            this.rbPagEfetuado.Enabled = false;
            this.rbPagEfetuado.Location = new System.Drawing.Point(409, 105);
            this.rbPagEfetuado.Name = "rbPagEfetuado";
            this.rbPagEfetuado.Size = new System.Drawing.Size(68, 17);
            this.rbPagEfetuado.TabIndex = 40;
            this.rbPagEfetuado.Text = "Efetuado";
            this.rbPagEfetuado.UseVisualStyleBackColor = true;
            // 
            // rbPagTodos
            // 
            this.rbPagTodos.AutoSize = true;
            this.rbPagTodos.Checked = true;
            this.rbPagTodos.Enabled = false;
            this.rbPagTodos.Location = new System.Drawing.Point(269, 105);
            this.rbPagTodos.Name = "rbPagTodos";
            this.rbPagTodos.Size = new System.Drawing.Size(55, 17);
            this.rbPagTodos.TabIndex = 41;
            this.rbPagTodos.TabStop = true;
            this.rbPagTodos.Text = "Todos";
            this.rbPagTodos.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(529, 103);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(128, 21);
            this.cbStatus.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(97, 103);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(96, 20);
            this.dtData.TabIndex = 45;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 130);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(829, 316);
            this.dgvPesquisa.TabIndex = 46;
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btImprimir);
            this.gbRelatorio.Location = new System.Drawing.Point(744, 46);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(97, 78);
            this.gbRelatorio.TabIndex = 47;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Impressão";
            this.gbRelatorio.Visible = false;
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(6, 18);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(83, 54);
            this.btImprimir.TabIndex = 27;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.AutoSize = true;
            this.lbRelatorio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelatorio.Location = new System.Drawing.Point(277, 9);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(215, 33);
            this.lbRelatorio.TabIndex = 48;
            this.lbRelatorio.Text = "Relatório Pedidos";
            this.lbRelatorio.Visible = false;
            // 
            // pesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 458);
            this.Controls.Add(this.gbRelatorio);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.rbPagTodos);
            this.Controls.Add(this.rbPagEfetuado);
            this.Controls.Add(this.rbPagAberto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPesq);
            this.Controls.Add(this.tbPalavraChave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.lbProcura);
            this.Controls.Add(this.lbRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pesPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Pedido";
            this.Load += new System.EventHandler(this.pesPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPesq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPagAberto;
        private System.Windows.Forms.RadioButton rbPagEfetuado;
        private System.Windows.Forms.RadioButton rbPagTodos;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        public System.Windows.Forms.GroupBox gbRelatorio;
        private System.Windows.Forms.Button btImprimir;
        public System.Windows.Forms.Label lbRelatorio;
        public System.Windows.Forms.Label lbProcura;
    }
}