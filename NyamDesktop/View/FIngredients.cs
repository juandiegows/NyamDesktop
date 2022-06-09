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
    public partial class FIngredients : Form
    {
        public FIngredients()
        {
            InitializeComponent();
            FPList.Controls.Clear();
            using (DBNaymNyamEntities model = new DBNaymNyamEntities())
            {
                foreach (var item in model.Ingredients.ToList())
                {
                    FPList.Controls.Add(new ctrlIngrediente(item));
                }
            }
        }
    }
}
