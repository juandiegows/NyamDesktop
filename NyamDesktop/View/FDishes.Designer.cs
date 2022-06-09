
namespace NyamDesktop.View
{
    partial class FDishes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TMinimun = new System.Windows.Forms.TrackBar();
            this.TPriceMaximum = new System.Windows.Forms.TrackBar();
            this.FPList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPriceMinimun = new System.Windows.Forms.Label();
            this.lblMaximun = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TMinimun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPriceMaximum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoad
            // 
            this.lblLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoad.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.Black;
            this.lblLoad.Location = new System.Drawing.Point(0, 0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(800, 48);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "List of Dishes";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(105, 60);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(175, 29);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(361, 25);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show only dishes with available ingredients";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(514, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 27);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // TMinimun
            // 
            this.TMinimun.Location = new System.Drawing.Point(514, 106);
            this.TMinimun.Maximum = 100;
            this.TMinimun.Name = "TMinimun";
            this.TMinimun.Size = new System.Drawing.Size(104, 45);
            this.TMinimun.TabIndex = 7;
            this.TMinimun.TickFrequency = 10;
            this.TMinimun.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TPriceMaximum
            // 
            this.TPriceMaximum.Location = new System.Drawing.Point(610, 106);
            this.TPriceMaximum.Maximum = 100;
            this.TPriceMaximum.Name = "TPriceMaximum";
            this.TPriceMaximum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TPriceMaximum.Size = new System.Drawing.Size(104, 45);
            this.TPriceMaximum.SmallChange = 10;
            this.TPriceMaximum.TabIndex = 7;
            this.TPriceMaximum.TickFrequency = 10;
            this.TPriceMaximum.Value = 100;
            this.TPriceMaximum.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // FPList
            // 
            this.FPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FPList.AutoScroll = true;
            this.FPList.Location = new System.Drawing.Point(17, 174);
            this.FPList.Name = "FPList";
            this.FPList.Size = new System.Drawing.Size(771, 264);
            this.FPList.TabIndex = 8;
            this.FPList.Paint += new System.Windows.Forms.PaintEventHandler(this.FPList_Paint);
            // 
            // lblPriceMinimun
            // 
            this.lblPriceMinimun.AutoSize = true;
            this.lblPriceMinimun.Location = new System.Drawing.Point(552, 149);
            this.lblPriceMinimun.Name = "lblPriceMinimun";
            this.lblPriceMinimun.Size = new System.Drawing.Size(32, 21);
            this.lblPriceMinimun.TabIndex = 3;
            this.lblPriceMinimun.Text = "0 $";
            // 
            // lblMaximun
            // 
            this.lblMaximun.AutoSize = true;
            this.lblMaximun.Location = new System.Drawing.Point(636, 148);
            this.lblMaximun.Name = "lblMaximun";
            this.lblMaximun.Size = new System.Drawing.Size(50, 21);
            this.lblMaximun.TabIndex = 3;
            this.lblMaximun.Text = "100 $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Count";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(79, 150);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 19);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // FDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FPList);
            this.Controls.Add(this.TPriceMaximum);
            this.Controls.Add(this.TMinimun);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblMaximun);
            this.Controls.Add(this.lblPriceMinimun);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoad);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDishes";
            this.Text = "FDishes";
            ((System.ComponentModel.ISupportInitialize)(this.TMinimun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPriceMaximum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TMinimun;
        private System.Windows.Forms.TrackBar TPriceMaximum;
        private System.Windows.Forms.FlowLayoutPanel FPList;
        private System.Windows.Forms.Label lblPriceMinimun;
        private System.Windows.Forms.Label lblMaximun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount;
    }
}