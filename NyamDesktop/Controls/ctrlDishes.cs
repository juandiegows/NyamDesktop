using NyamDesktop.Models;
using NyamDesktop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyamDesktop.Controls
{
    public partial class ctrlDishes : UserControl
    {
        public Dish Dish;
        public ctrlDishes(Dish dish)
        {
            Dish = dish;
            InitializeComponent();
            lblTitle.Text = dish.DishName;
            lblDescription.Text = dish.Description;
            lblPortion.Text = $"1 portion = {dish.Price}$";
            var img = global::NyamDesktop.Properties.Resources.ResourceManager.GetObject("_" + dish.ImagePath.Split('.')[0]) as Image;
            pIMG.Image = img;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.fMenu.AbrirForm(new FRecipe(Dish));
        }
    }
}
