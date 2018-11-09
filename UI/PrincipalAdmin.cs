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
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void PrincipalAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuario abrir = new cadUsuario();
            abrir.Show();
        }

        private void gerenciarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modUsuario abrir = new modUsuario();
            abrir.Show();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesUsuario abrir = new pesUsuario();
            abrir.Show();
        }
    }
}
