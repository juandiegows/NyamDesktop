using Microsoft.Office.Interop.Excel;
using NyamDesktop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyamDesktop
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(213, 200, 71);

            lblLoad.ForeColor = Color.FromArgb(238, 212, 254);
            this.Show();

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = oExcel.Workbooks.Add();


            Microsoft.Office.Interop.Excel.Worksheet hoja = (Worksheet)oExcel.Worksheets[1];
            hoja.Cells[1, 1] = "Hello world";
            string title = " Excel Export by Camellabs";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.pdf)|*.pdf";
            sfd.FileName = "camellabs.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.Saved = true;
                workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, sfd.FileName);
                workbook.Close();

                MessageBox.Show("Finish");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Abrir_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Abrir.Enabled = false;
            Util.fMenu = new FMenu();
            Util.fMenu.ShowDialog();
        }
    }
}
