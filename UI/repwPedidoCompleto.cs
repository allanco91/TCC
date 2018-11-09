using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHOP.UI
{
    public partial class repwPedidoCompleto : Form
    {
        public repwPedidoCompleto()
        {
            InitializeComponent();
        }

        private void rewpPedidoCompleto_Load(object sender, EventArgs e)
        {
            this.rvClienteCompleto.RefreshReport();
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            pg.Landscape = true;
            rvClienteCompleto.SetPageSettings(pg);
            rvClienteCompleto.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvClienteCompleto.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
