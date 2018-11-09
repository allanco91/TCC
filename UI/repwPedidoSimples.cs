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
    public partial class repwPedidoSimples : Form
    {
        public repwPedidoSimples()
        {
            InitializeComponent();
        }

        private void repwPedidoSimples_Load(object sender, EventArgs e)
        {
            this.rvPedidoSimples.RefreshReport();

            rvPedidoSimples.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvPedidoSimples.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
