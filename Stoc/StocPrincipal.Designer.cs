using System;

namespace Stoc
{
    partial class StocPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.stocToolStripMenuItem,
            this.raportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.ProduseToolStripMenuItem_Click);
            // 
            // stocToolStripMenuItem
            // 
            this.stocToolStripMenuItem.Name = "stocToolStripMenuItem";
            this.stocToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stocToolStripMenuItem.Text = "Stoc";
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsToolStripMenuItem});
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.produsToolStripMenuItem.Text = "Produs";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1047, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // StocPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 603);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StocPrincipal";
            this.Text = "Administrare stoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StocPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.StocPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
    }
}



