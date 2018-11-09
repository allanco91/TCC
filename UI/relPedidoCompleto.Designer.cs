namespace SHOP.UI
{
    partial class relPedidoCompleto
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
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btImprimirCompleto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btImprimirSimples = new System.Windows.Forms.Button();
            this.rbNTotaliza = new System.Windows.Forms.RadioButton();
            this.rbTotalizar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(186, 103);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(204, 29);
            this.dtDataInicial.TabIndex = 0;
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(186, 144);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(204, 29);
            this.dtDataFinal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(186, 179);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(204, 32);
            this.cbStatus.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data final:";
            // 
            // btImprimirCompleto
            // 
            this.btImprimirCompleto.Location = new System.Drawing.Point(246, 217);
            this.btImprimirCompleto.Name = "btImprimirCompleto";
            this.btImprimirCompleto.Size = new System.Drawing.Size(144, 56);
            this.btImprimirCompleto.TabIndex = 46;
            this.btImprimirCompleto.Text = "Imprimir Completo";
            this.btImprimirCompleto.UseVisualStyleBackColor = true;
            this.btImprimirCompleto.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Relatório pedidos";
            // 
            // btImprimirSimples
            // 
            this.btImprimirSimples.Location = new System.Drawing.Point(80, 217);
            this.btImprimirSimples.Name = "btImprimirSimples";
            this.btImprimirSimples.Size = new System.Drawing.Size(144, 56);
            this.btImprimirSimples.TabIndex = 46;
            this.btImprimirSimples.Text = "Imprimir Simples";
            this.btImprimirSimples.UseVisualStyleBackColor = true;
            this.btImprimirSimples.Click += new System.EventHandler(this.btImprimirSimples_Click);
            // 
            // rbNTotaliza
            // 
            this.rbNTotaliza.AutoSize = true;
            this.rbNTotaliza.Checked = true;
            this.rbNTotaliza.Location = new System.Drawing.Point(414, 103);
            this.rbNTotaliza.Name = "rbNTotaliza";
            this.rbNTotaliza.Size = new System.Drawing.Size(119, 17);
            this.rbNTotaliza.TabIndex = 47;
            this.rbNTotaliza.TabStop = true;
            this.rbNTotaliza.Text = "Não totalizar por dia";
            this.rbNTotaliza.UseVisualStyleBackColor = true;
            this.rbNTotaliza.CheckedChanged += new System.EventHandler(this.rbNTotaliza_CheckedChanged);
            // 
            // rbTotalizar
            // 
            this.rbTotalizar.AutoSize = true;
            this.rbTotalizar.Location = new System.Drawing.Point(414, 130);
            this.rbTotalizar.Name = "rbTotalizar";
            this.rbTotalizar.Size = new System.Drawing.Size(100, 17);
            this.rbTotalizar.TabIndex = 47;
            this.rbTotalizar.Text = "Totalizar por dia";
            this.rbTotalizar.UseVisualStyleBackColor = true;
            this.rbTotalizar.CheckedChanged += new System.EventHandler(this.rbTotalizar_CheckedChanged);
            // 
            // relPedidoCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 313);
            this.Controls.Add(this.rbTotalizar);
            this.Controls.Add(this.rbNTotaliza);
            this.Controls.Add(this.btImprimirSimples);
            this.Controls.Add(this.btImprimirCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtDataFinal);
            this.Controls.Add(this.dtDataInicial);
            this.Name = "relPedidoCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório pedidos (por data)";
            this.Load += new System.EventHandler(this.relPedidoCompleto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btImprimirCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btImprimirSimples;
        private System.Windows.Forms.RadioButton rbNTotaliza;
        private System.Windows.Forms.RadioButton rbTotalizar;
    }
}