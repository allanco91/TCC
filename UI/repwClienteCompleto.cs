﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHOP.UI
{
    public partial class repwClienteCompleto : Form
    {
        public repwClienteCompleto()
        {
            InitializeComponent();
        }

        private void repwClienteCompleto_Load(object sender, EventArgs e)
        {
            this.rvClienteCompleto.RefreshReport();

            rvClienteCompleto.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvClienteCompleto.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
