namespace PresentationLayer
{
    partial class ShowVitamins
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
            this.listBoxShowVitamins = new System.Windows.Forms.ListBox();
            this.menuShowVitamin = new System.Windows.Forms.MenuStrip();
            this.HomeSymptomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseSymptomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonChooseSymptom = new System.Windows.Forms.Button();
            this.menuShowVitamin.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxShowVitamins
            // 
            this.listBoxShowVitamins.FormattingEnabled = true;
            this.listBoxShowVitamins.ItemHeight = 20;
            this.listBoxShowVitamins.Location = new System.Drawing.Point(42, 82);
            this.listBoxShowVitamins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxShowVitamins.Name = "listBoxShowVitamins";
            this.listBoxShowVitamins.Size = new System.Drawing.Size(908, 364);
            this.listBoxShowVitamins.TabIndex = 0;
            // 
            // menuShowVitamin
            // 
            this.menuShowVitamin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuShowVitamin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeSymptomToolStripMenuItem,
            this.ChooseSymptomToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuShowVitamin.Location = new System.Drawing.Point(0, 0);
            this.menuShowVitamin.Name = "menuShowVitamin";
            this.menuShowVitamin.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuShowVitamin.Size = new System.Drawing.Size(1000, 31);
            this.menuShowVitamin.TabIndex = 2;
            this.menuShowVitamin.Text = "menuUserHome";
            // 
            // HomeSymptomToolStripMenuItem
            // 
            this.HomeSymptomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSymptomToolStripMenuItem.Name = "HomeSymptomToolStripMenuItem";
            this.HomeSymptomToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.HomeSymptomToolStripMenuItem.Text = "Pocetna";
            this.HomeSymptomToolStripMenuItem.Click += new System.EventHandler(this.HomeSymptomToolStripMenuItem_Click);
            // 
            // ChooseSymptomToolStripMenuItem
            // 
            this.ChooseSymptomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSymptomToolStripMenuItem.Name = "ChooseSymptomToolStripMenuItem";
            this.ChooseSymptomToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.ChooseSymptomToolStripMenuItem.Text = "Izbor simptoma";
            this.ChooseSymptomToolStripMenuItem.Click += new System.EventHandler(this.ChooseSymptomToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(650, 0, 0, 0);
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.LogOutToolStripMenuItem.Text = "Odjava";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // buttonChooseSymptom
            // 
            this.buttonChooseSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseSymptom.Location = new System.Drawing.Point(360, 472);
            this.buttonChooseSymptom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChooseSymptom.Name = "buttonChooseSymptom";
            this.buttonChooseSymptom.Size = new System.Drawing.Size(265, 52);
            this.buttonChooseSymptom.TabIndex = 3;
            this.buttonChooseSymptom.Text = "Izaberi svoje simptome";
            this.buttonChooseSymptom.UseVisualStyleBackColor = true;
            this.buttonChooseSymptom.Click += new System.EventHandler(this.buttonChooseSymptom_Click);
            // 
            // ShowVitamins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.buttonChooseSymptom);
            this.Controls.Add(this.menuShowVitamin);
            this.Controls.Add(this.listBoxShowVitamins);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowVitamins";
            this.Text = "Pregled vitamina";
            this.Load += new System.EventHandler(this.ShowVitamins_Load);
            this.menuShowVitamin.ResumeLayout(false);
            this.menuShowVitamin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowVitamins;
        private System.Windows.Forms.MenuStrip menuShowVitamin;
        private System.Windows.Forms.ToolStripMenuItem HomeSymptomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseSymptomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.Button buttonChooseSymptom;
    }
}