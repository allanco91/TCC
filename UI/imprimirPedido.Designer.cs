namespace SHOP.UI
{
    partial class imprimirPedido
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.tbNumeropedido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(98, 139);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(101, 51);
            this.btImprimir.TabIndex = 0;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // tbNumeropedido
            // 
            this.tbNumeropedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeropedido.Location = new System.Drawing.Point(171, 88);
            this.tbNumeropedido.Name = "tbNumeropedido";
            this.tbNumeropedido.Size = new System.Drawing.Size(188, 35);
            this.tbNumeropedido.TabIndex = 7;
            this.tbNumeropedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumeropedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeropedido_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 29);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nº Pedido";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(205, 139);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(101, 51);
            this.btLimpar.TabIndex = 0;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imprimir pedido";
            // 
            // imprimirPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumeropedido);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btImprimir);
            this.Name = "imprimirPedido";
            this.Text = "Impressão de pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.TextBox tbNumeropedido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label1;
    }
}