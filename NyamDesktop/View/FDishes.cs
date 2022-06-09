using NyamDesktop.Controls;
using NyamDesktop.Models;
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
    public partial class FDishes : Form
    {
        public FDishes()
        {
            InitializeComponent();
            FillCategoryComboBox();
            FillDish();
        }

        private void FillCategoryComboBox()
        {
            using (DBNaymNyamEntities model = new DBNaymNyamEntities())
            {
                var lista = model.Categories.ToList();
                lista.Insert(0, new Category
                {
                    ID = 0,
                    CategoryName = "All Category"
                });
                cmbCategory.DataSource = lista;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "ID";
            }
        }

        private void FillDish()
        {
            try
            {
                FPList.Controls.Clear();
                int CategoryID = (int)cmbCategory.SelectedValue;
                using (DBNaymNyamEntities model = new DBNaymNyamEntities())
                {
                    foreach (var item in model.Dishes.ToList().Where(
                        x => (x.CategoryID == CategoryID || CategoryID == 0)
                        && (txtName.Text.Length < 3 || x.DishName.ToUpper().Contains(txtName.Text.ToUpper()))
                        && (x.Price > TMinimun.Value)
                        && (x.Price < TPriceMaximum.Value)
                        ).ToList())
                    {
                        FPList.Controls.Add(new ctrlDishes(item));
                    }
                    lblCount.Text = FPList.Controls.Count.ToString();
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDish();
        }

        private void FPList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDish();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPriceMinimun.Text = $"{TMinimun.Value}$";
            FillDish();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblMaximun.Text = $"{TPriceMaximum.Value}$";
            FillDish();
        }
    }
}
