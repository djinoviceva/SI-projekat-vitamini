namespace PresentationLayer
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.menuUserHome = new System.Windows.Forms.MenuStrip();
            this.ChooseSymptomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VitaminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuUserHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuUserHome
            // 
            this.menuUserHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUserHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseSymptomToolStripMenuItem,
            this.VitaminsToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuUserHome.Location = new System.Drawing.Point(0, 0);
            this.menuUserHome.Name = "menuUserHome";
            this.menuUserHome.Size = new System.Drawing.Size(800, 31);
            this.menuUserHome.TabIndex = 0;
            this.menuUserHome.Text = "menuUserHome";
            // 
            // ChooseSymptomToolStripMenuItem
            // 
            this.ChooseSymptomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSymptomToolStripMenuItem.Name = "ChooseSymptomToolStripMenuItem";
            this.ChooseSymptomToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.ChooseSymptomToolStripMenuItem.Text = "Izbor simptoma";
            this.ChooseSymptomToolStripMenuItem.Click += new System.EventHandler(this.ChooseSymptomToolStripMenuItem_Click);
            // 
            // VitaminsToolStripMenuItem
            // 
            this.VitaminsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitaminsToolStripMenuItem.Name = "VitaminsToolStripMenuItem";
            this.VitaminsToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.VitaminsToolStripMenuItem.Text = "Pregled vitamina";
            this.VitaminsToolStripMenuItem.Click += new System.EventHandler(this.VitaminsToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(400, 0, 0, 0);
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.LogOutToolStripMenuItem.Text = "Odjava";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuUserHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuUserHome;
            this.Name = "UserHome";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.menuUserHome.ResumeLayout(false);
            this.menuUserHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuUserHome;
        private System.Windows.Forms.ToolStripMenuItem ChooseSymptomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VitaminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}