﻿namespace SHOP.UI
{
    partial class repwClienteSimples
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
            this.rvClienteSimples = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorioClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvClienteSimples
            // 
            this.rvClienteSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCliente";
            reportDataSource1.Value = this.relatorioClienteBindingSource;
            this.rvClienteSimples.LocalReport.DataSources.Add(reportDataSource1);
            this.rvClienteSimples.LocalReport.ReportEmbeddedResource = "SHOP.Report.repClienteSimples.rdlc";
            this.rvClienteSimples.Location = new System.Drawing.Point(0, 0);
            this.rvClienteSimples.Name = "rvClienteSimples";
            this.rvClienteSimples.Size = new System.Drawing.Size(284, 262);
            this.rvClienteSimples.TabIndex = 0;
            // 
            // relatorioClienteBindingSource
            // 
            this.relatorioClienteBindingSource.DataMember = "relatorioCliente";
            // 
            // repwClienteSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rvClienteSimples);
            this.MinimizeBox = false;
            this.Name = "repwClienteSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório clientes (simples)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwClienteSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClienteSimples;
        public System.Windows.Forms.BindingSource relatorioClienteBindingSource;
    }
}