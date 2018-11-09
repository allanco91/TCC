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
    public partial class repwCategoria : Form
    {
        public repwCategoria()
        {
            InitializeComponent();
        }

        private void repwCategoria_Load(object sender, EventArgs e)
        {
            this.rvCategoria.RefreshReport();

            rvCategoria.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvCategoria.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
