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

namespace NyamDesktop.Controls
{
    public partial class ctrlIngrediente : UserControl
    {
        Ingredient ingredient1;
        public ctrlIngrediente(Ingredient ingredient)
        {
            ingredient1 = ingredient;
            InitializeComponent();
            lblPrice.Text = ingredient.PriceUnit;
            lblTitle.Text = ingredient.IngredientName;
            nupUnit.Value = ingredient.CountStock;
        }

        private void nupUnit_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (DBNaymNyamEntities model = new DBNaymNyamEntities())
                {
                    ingredient1.CountStock++;
                    model.Entry(ingredient1).State = System.Data.Entity.EntityState.Modified;
                    model.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (DBNaymNyamEntities model = new DBNaymNyamEntities())
            {
                try
                {
                    model.Ingredients.Remove(model.Ingredients.FirstOrDefault(x => x.ID ==ingredient1.ID));
                    if(model.SaveChanges()> 0)
                    {
                        MessageBox.Show("delete sucessful");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("the ingredients is used");
                }

            }
        }
    }
}
