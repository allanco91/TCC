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
    public partial class repwPedidoPorData : Form
    {
        public repwPedidoPorData()
        {
            InitializeComponent();
        }

        private void repwPedidoPorData1_Load(object sender, EventArgs e)
        {

            this.rvPedidoPorData.RefreshReport();

            rvPedidoPorData.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvPedidoPorData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
        }
    }
}
