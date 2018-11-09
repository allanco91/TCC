namespace SHOP.UI
{
    partial class repwPedidoPorData
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
            this.rvPedidoPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pesqPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pesqPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvPedidoPorData
            // 
            this.rvPedidoPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPedidoSimples";
            reportDataSource1.Value = this.pesqPedidoBindingSource;
            this.rvPedidoPorData.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPedidoPorData.LocalReport.ReportEmbeddedResource = "SHOP.Report.repPedidoPorDataRegistro.rdlc";
            this.rvPedidoPorData.Location = new System.Drawing.Point(0, 0);
            this.rvPedidoPorData.Name = "rvPedidoPorData";
            this.rvPedidoPorData.Size = new System.Drawing.Size(284, 262);
            this.rvPedidoPorData.TabIndex = 0;
            // 
            // pesqPedidoBindingSource
            // 
            this.pesqPedidoBindingSource.DataSource = typeof(SHOP.DAL.dalPedido.pesqPedido);
            // 
            // repwPedidoPorData1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rvPedidoPorData);
            this.MaximizeBox = false;
            this.Name = "repwPedidoPorData1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório pedido por data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwPedidoPorData1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pesqPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPedidoPorData;
        public System.Windows.Forms.BindingSource pesqPedidoBindingSource;
    }
}