
namespace NyamDesktop.View
{
    partial class FMenu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FPLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisnes = new System.Windows.Forms.LinkLabel();
            this.lblIngredients = new System.Windows.Forms.LinkLabel();
            this.lblOrders = new System.Windows.Forms.LinkLabel();
            this.PCPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.FPLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FPLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PCPrincipal);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 450);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // FPLeft
            // 
            this.FPLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FPLeft.Controls.Add(this.label1);
            this.FPLeft.Controls.Add(this.lblDisnes);
            this.FPLeft.Controls.Add(this.lblIngredients);
            this.FPLeft.Controls.Add(this.lblOrders);
            this.FPLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FPLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FPLeft.Location = new System.Drawing.Point(0, 0);
            this.FPLeft.Name = "FPLeft";
            this.FPLeft.Padding = new System.Windows.Forms.Padding(10);
            this.FPLeft.Size = new System.Drawing.Size(267, 450);
            this.FPLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // lblDisnes
            // 
            this.lblDisnes.AutoSize = true;
            this.lblDisnes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisnes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblDisnes.Location = new System.Drawing.Point(13, 82);
            this.lblDisnes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblDisnes.Name = "lblDisnes";
            this.lblDisnes.Size = new System.Drawing.Size(56, 19);
            this.lblDisnes.TabIndex = 0;
            this.lblDisnes.TabStop = true;
            this.lblDisnes.Text = "dishes";
            this.lblDisnes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDisnes_LinkClicked);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblIngredients.Location = new System.Drawing.Point(13, 121);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(94, 19);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.TabStop = true;
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblIngredients_LinkClicked);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblOrders.Location = new System.Drawing.Point(13, 160);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(59, 19);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.TabStop = true;
            this.lblOrders.Text = "Orders";
            this.lblOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOrders_LinkClicked);
            // 
            // PCPrincipal
            // 
            this.PCPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PCPrincipal.Name = "PCPrincipal";
            this.PCPrincipal.Size = new System.Drawing.Size(913, 450);
            this.PCPrincipal.TabIndex = 0;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1000, 0);
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMenu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.FPLeft.ResumeLayout(false);
            this.FPLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel FPLeft;
        private System.Windows.Forms.LinkLabel lblDisnes;
        private System.Windows.Forms.LinkLabel lblIngredients;
        private System.Windows.Forms.LinkLabel lblOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PCPrincipal;
    }
}