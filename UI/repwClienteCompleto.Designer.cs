namespace SHOP.UI
{
    partial class repwClienteCompleto
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
            this.rvClienteCompleto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostraClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostraClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvClienteCompleto
            // 
            this.rvClienteCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCliente";
            reportDataSource1.Value = this.mostraClienteBindingSource;
            this.rvClienteCompleto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvClienteCompleto.LocalReport.ReportEmbeddedResource = "SHOP.Report.repClienteCompleto.rdlc";
            this.rvClienteCompleto.Location = new System.Drawing.Point(0, 0);
            this.rvClienteCompleto.Name = "rvClienteCompleto";
            this.rvClienteCompleto.Size = new System.Drawing.Size(284, 262);
            this.rvClienteCompleto.TabIndex = 0;
            // 
            // mostraClienteBindingSource
            // 
            this.mostraClienteBindingSource.DataSource = typeof(SHOP.DAL.dalCliente.mostraCliente);
            // 
            // repwClienteCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rvClienteCompleto);
            this.MaximizeBox = false;
            this.Name = "repwClienteCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório clientes (completo)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwClienteCompleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostraClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClienteCompleto;
        public System.Windows.Forms.BindingSource mostraClienteBindingSource;
    }
}