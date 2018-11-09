namespace SHOP.UI
{
    partial class repwProduto
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
            this.rvProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultaProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultaProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvProduto
            // 
            this.rvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProdutos";
            reportDataSource1.Value = this.consultaProdutoBindingSource;
            this.rvProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvProduto.LocalReport.ReportEmbeddedResource = "SHOP.Report.repProduto.rdlc";
            this.rvProduto.Location = new System.Drawing.Point(0, 0);
            this.rvProduto.Name = "rvProduto";
            this.rvProduto.Size = new System.Drawing.Size(284, 261);
            this.rvProduto.TabIndex = 0;
            // 
            // consultaProdutoBindingSource
            // 
            this.consultaProdutoBindingSource.DataSource = typeof(SHOP.DAL.dalProduto.consultaProduto);
            // 
            // repwProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvProduto);
            this.MaximizeBox = false;
            this.Name = "repwProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProduto;
        public System.Windows.Forms.BindingSource consultaProdutoBindingSource;
    }
}