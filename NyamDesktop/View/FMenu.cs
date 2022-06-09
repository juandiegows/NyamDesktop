using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyamDesktop.View
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            FPLeft.BackColor = Color.FromArgb(253, 178, 73);
            PCPrincipal.BackColor = Color.FromArgb(254, 215, 193);
        }
        public void AbrirForm(Form form)
        {
            PCPrincipal.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            PCPrincipal.Controls.Add(form);
        }
        private void lblDisnes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirForm(Util.FDishes = new FDishes());
        }

        private void lblIngredients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirForm(new FIngredients());
        }

        private void lblOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirForm(new FOrders());
        }
    }
}
