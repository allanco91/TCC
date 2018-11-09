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
    public partial class repwProduto : Form
    {
        public repwProduto()
        {
            InitializeComponent();
        }

        private void repwProduto_Load(object sender, EventArgs e)
        {
            this.rvProduto.RefreshReport();

            rvProduto.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvProduto.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
