﻿namespace SHOP.UI
{
    partial class repwImprimePedido
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
            this.rvImprimePedido = new Microsoft.Reporting.WinForms.ReportViewer();
            this.imprimePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imprimePedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvImprimePedido
            // 
            this.rvImprimePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsImprimePedido";
            reportDataSource1.Value = this.imprimePedidoBindingSource;
            this.rvImprimePedido.LocalReport.DataSources.Add(reportDataSource1);
            this.rvImprimePedido.LocalReport.ReportEmbeddedResource = "SHOP.Report.repImprimePedido.rdlc";
            this.rvImprimePedido.Location = new System.Drawing.Point(0, 0);
            this.rvImprimePedido.Name = "rvImprimePedido";
            this.rvImprimePedido.Size = new System.Drawing.Size(284, 261);
            this.rvImprimePedido.TabIndex = 0;
            // 
            // imprimePedidoBindingSource
            // 
            this.imprimePedidoBindingSource.DataSource = typeof(SHOP.DAL.dalPedido.imprimePedido);
            // 
            // repwImprimePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvImprimePedido);
            this.MaximizeBox = false;
            this.Name = "repwImprimePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprime Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repwImprimePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imprimePedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvImprimePedido;
        public System.Windows.Forms.BindingSource imprimePedidoBindingSource;
    }
}