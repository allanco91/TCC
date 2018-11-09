namespace SHOP.UI
{
    partial class repwPedidoSimples
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvPedidoSimples = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pesqPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pesqPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvPedidoSimples
            // 
            this.rvPedidoSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPedidoSimples";
            reportDataSource1.Value = this.pesqPedidoBindingSource;
            this.rvPedidoSimples.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPedidoSimples.LocalReport.ReportEmbeddedResource = "SHOP.Report.repPedidoSimples.rdlc";
            this.rvPedidoSimples.Location = new System.Drawing.Point(0, 0);
            this.rvPedidoSimples.Name = "rvPedidoSimples";
            this.rvPedidoSimples.Size = new System.Drawing.Size(284, 261);
            this.rvPedidoSimples.TabIndex = 0;
            // 
            // pesqPedidoBindingSource
            // 
            this.pesqPedidoBindingSource.DataSource = typeof(SHOP.DAL.dalPedido.pesqPedido);
            // 
            // repwPedidoSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvPedidoSimples);
            this.Name = "repwPedidoSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de pedido (simples)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwPedidoSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pesqPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPedidoSimples;
        public System.Windows.Forms.BindingSource pesqPedidoBindingSource;
    }
}