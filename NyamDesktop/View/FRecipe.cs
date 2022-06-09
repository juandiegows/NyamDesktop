using Microsoft.Office.Interop.Excel;
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
    public partial class FRecipe : Form
    {
        public FRecipe(Dish dish)
        {
            InitializeComponent();
            lblTitle.Text = $"Recipes for \"{dish.DishName}\"";

            lblShort.Text = dish.Description;
            double total = dish.Price;
            List<ViewIngredients> ViewIngredients = new List<ViewIngredients>();
            using (DBNaymNyamEntities model = new DBNaymNyamEntities())
            {
                lblCategory.Text = model.Dishes.FirstOrDefault(x => x.ID == dish.ID).Category.CategoryName;
                lblCooking.Text = $"{model.Processes.ToList().Where(x => x.Recipe.DishID == dish.ID).ToList().Sum(c => c.Time).ToString()} min.";
                int count = 1;
                foreach (var item in model.Processes.ToList().Where(x => x.Recipe.DishID == dish.ID).ToList())
                {
                    foreach (var item2 in item.ProcessIngredients.ToList())
                    {
                        int.TryParse(item2.Ingredient.PriceUnit.Trim().Split('$')[0].Split(' ')[0].Trim(), out int cost);
                        total += cost;
                        ViewIngredients.Add(new NyamDesktop.ViewIngredients
                        {
                            Name = item2.Ingredient.IngredientName,
                            Quantity = item2.Quantity.ToString(),
                            Cost = item2.Ingredient.PriceUnit,
                            Unit = item2.Ingredient.MainUnit
                        });
                    }
                    cmbList.Items.Add($"{count} {item.Description}");
                    count++;
                }

            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ViewIngredients;
            lblCostT.Text = $"{total}$";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.fMenu.AbrirForm(Util.FDishes);
        }
    }
}
