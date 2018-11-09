namespace SHOP.UI
{
    partial class prodSemEstoque
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvSemEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ItensViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ItensViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvSemEstoque
            // 
            this.rvSemEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsSemEstoque";
            reportDataSource2.Value = this.ItensViewBindingSource;
            this.rvSemEstoque.LocalReport.DataSources.Add(reportDataSource2);
            this.rvSemEstoque.LocalReport.ReportEmbeddedResource = "SHOP.Report.repSemEstoque.rdlc";
            this.rvSemEstoque.Location = new System.Drawing.Point(0, 0);
            this.rvSemEstoque.Name = "rvSemEstoque";
            this.rvSemEstoque.Size = new System.Drawing.Size(802, 485);
            this.rvSemEstoque.TabIndex = 0;
            // 
            // ItensViewBindingSource
            // 
            this.ItensViewBindingSource.DataSource = typeof(SHOP.UI.gerPedido.ItensView);
            // 
            // prodSemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.rvSemEstoque);
            this.MaximizeBox = false;
            this.Name = "prodSemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos sem estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.prodSemEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvSemEstoque;
        public System.Windows.Forms.BindingSource ItensViewBindingSource;


    }
}