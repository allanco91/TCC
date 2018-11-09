namespace SHOP.UI
{
    partial class gerPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.tbNumeropedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbValorTotalPedido = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLiberar = new System.Windows.Forms.Button();
            this.btEntrega = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPagamento = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gerenciar Pedidos";
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(811, 51);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(101, 35);
            this.btProcurar.TabIndex = 25;
            this.btProcurar.Text = "Procurar Pedido";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // tbNumeropedido
            // 
            this.tbNumeropedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeropedido.Location = new System.Drawing.Point(617, 51);
            this.tbNumeropedido.Name = "tbNumeropedido";
            this.tbNumeropedido.Size = new System.Drawing.Size(188, 35);
            this.tbNumeropedido.TabIndex = 24;
            this.tbNumeropedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumeropedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeropedido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome/Razão Social:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(156, 92);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(756, 27);
            this.tbNome.TabIndex = 29;
            // 
            // tbValorTotalPedido
            // 
            this.tbValorTotalPedido.Enabled = false;
            this.tbValorTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorTotalPedido.ForeColor = System.Drawing.Color.Red;
            this.tbValorTotalPedido.Location = new System.Drawing.Point(685, 427);
            this.tbValorTotalPedido.Name = "tbValorTotalPedido";
            this.tbValorTotalPedido.Size = new System.Drawing.Size(227, 31);
            this.tbValorTotalPedido.TabIndex = 32;
            this.tbValorTotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvItens
            // 
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Enabled = false;
            this.dgvItens.Location = new System.Drawing.Point(12, 128);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(900, 288);
            this.dgvItens.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total do pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nº Pedido";
            // 
            // btLiberar
            // 
            this.btLiberar.Enabled = false;
            this.btLiberar.Location = new System.Drawing.Point(12, 427);
            this.btLiberar.Name = "btLiberar";
            this.btLiberar.Size = new System.Drawing.Size(136, 70);
            this.btLiberar.TabIndex = 33;
            this.btLiberar.Text = "Liberar Pedido";
            this.btLiberar.UseVisualStyleBackColor = true;
            this.btLiberar.Click += new System.EventHandler(this.btLiberar_Click);
            // 
            // btEntrega
            // 
            this.btEntrega.Enabled = false;
            this.btEntrega.Location = new System.Drawing.Point(154, 427);
            this.btEntrega.Name = "btEntrega";
            this.btEntrega.Size = new System.Drawing.Size(136, 70);
            this.btEntrega.TabIndex = 33;
            this.btEntrega.Text = "Confirmar Entrega";
            this.btEntrega.UseVisualStyleBackColor = true;
            this.btEntrega.Click += new System.EventHandler(this.btEntrega_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.Enabled = false;
            this.btPagamento.Location = new System.Drawing.Point(296, 427);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(136, 70);
            this.btPagamento.TabIndex = 33;
            this.btPagamento.Text = "Confirmar Pagamento";
            this.btPagamento.UseVisualStyleBackColor = true;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(685, 464);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(130, 33);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "Cancelado";
            this.lbStatus.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pagamento";
            // 
            // lbPagamento
            // 
            this.lbPagamento.AutoSize = true;
            this.lbPagamento.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPagamento.Location = new System.Drawing.Point(685, 497);
            this.lbPagamento.Name = "lbPagamento";
            this.lbPagamento.Size = new System.Drawing.Size(167, 33);
            this.lbPagamento.TabIndex = 20;
            this.lbPagamento.Text = "Não Efetuado";
            this.lbPagamento.Visible = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Enabled = false;
            this.btLimpar.Location = new System.Drawing.Point(12, 502);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(420, 33);
            this.btLimpar.TabIndex = 33;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // gerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 543);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.btEntrega);
            this.Controls.Add(this.btLiberar);
            this.Controls.Add(this.tbValorTotalPedido);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.tbNumeropedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "gerPedido";
            this.Text = "Gerenciar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.TextBox tbNumeropedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbValorTotalPedido;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLiberar;
        private System.Windows.Forms.Button btEntrega;
        private System.Windows.Forms.Button btPagamento;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPagamento;
        private System.Windows.Forms.Button btLimpar;
    }
}