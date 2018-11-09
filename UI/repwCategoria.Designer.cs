namespace SHOP.UI
{
    partial class repwCategoria
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
            this.rvCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvCategoria
            // 
            this.rvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCategoria";
            reportDataSource1.Value = this.CategoriasBindingSource;
            this.rvCategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCategoria.LocalReport.ReportEmbeddedResource = "SHOP.Report.repCategoria.rdlc";
            this.rvCategoria.Location = new System.Drawing.Point(0, 0);
            this.rvCategoria.Name = "rvCategoria";
            this.rvCategoria.Size = new System.Drawing.Size(284, 262);
            this.rvCategoria.TabIndex = 0;
            // 
            // CategoriasBindingSource
            // 
            this.CategoriasBindingSource.DataSource = typeof(SHOP.Model.Categorias);
            // 
            // repwCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rvCategoria);
            this.Name = "repwCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório caterogia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCategoria;
        public System.Windows.Forms.BindingSource CategoriasBindingSource;
    }
}