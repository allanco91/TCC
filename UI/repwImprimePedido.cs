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
    public partial class repwImprimePedido : Form
    {
        public repwImprimePedido()
        {
            InitializeComponent();
        }

        private void repwImprimePedido_Load(object sender, EventArgs e)
        {
            this.rvImprimePedido.RefreshReport();

            rvImprimePedido.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvImprimePedido.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
