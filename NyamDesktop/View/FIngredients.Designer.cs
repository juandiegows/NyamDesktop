
namespace NyamDesktop.View
{
    partial class FIngredients
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
            this.FPList = new System.Windows.Forms.FlowLayoutPanel();
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
            this.lblLoad.TabIndex = 3;
            this.lblLoad.Text = "List of ingredients";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FPList
            // 
            this.FPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FPList.AutoScroll = true;
            this.FPList.Location = new System.Drawing.Point(0, 80);
            this.FPList.Name = "FPList";
            this.FPList.Size = new System.Drawing.Size(800, 370);
            this.FPList.TabIndex = 9;
            // 
            // FIngredients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FPList);
            this.Controls.Add(this.lblLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FIngredients";
            this.Text = "FIngredients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.FlowLayoutPanel FPList;
    }
}