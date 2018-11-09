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
    public partial class repwClienteSimples : Form
    {
        public repwClienteSimples()
        {
            InitializeComponent();
        }

        private void repwClienteSimples_Load(object sender, EventArgs e)
        {

            this.rvClienteSimples.RefreshReport();

            rvClienteSimples.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvClienteSimples.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
