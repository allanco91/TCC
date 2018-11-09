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
    public partial class prodSemEstoque : Form
    {
        public prodSemEstoque()
        {
            InitializeComponent();
        }

        private void prodSemEstoque_Load(object sender, EventArgs e)
        {
            this.rvSemEstoque.RefreshReport();

            rvSemEstoque.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvSemEstoque.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }
    }
}
