namespace PresentationLayer
{
    partial class ChooseSymptom
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
            this.menuChooseSymptom = new System.Windows.Forms.MenuStrip();
            this.HomeSymptomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VitaminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonS1 = new System.Windows.Forms.RadioButton();
            this.radioButtonS2 = new System.Windows.Forms.RadioButton();
            this.radioButtonS3 = new System.Windows.Forms.RadioButton();
            this.radioButtonS4 = new System.Windows.Forms.RadioButton();
            this.radioButtonS5 = new System.Windows.Forms.RadioButton();
            this.radioButtonS6 = new System.Windows.Forms.RadioButton();
            this.radioButtonS7 = new System.Windows.Forms.RadioButton();
            this.buttonSuggestVitamin = new System.Windows.Forms.Button();
            this.labelChooseSymptom = new System.Windows.Forms.Label();
            this.listBoxSuggestedVitamin = new System.Windows.Forms.ListBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.menuChooseSymptom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuChooseSymptom
            // 
            this.menuChooseSymptom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuChooseSymptom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeSymptomToolStripMenuItem,
            this.VitaminsToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuChooseSymptom.Location = new System.Drawing.Point(0, 0);
            this.menuChooseSymptom.Name = "menuChooseSymptom";
            this.menuChooseSymptom.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuChooseSymptom.Size = new System.Drawing.Size(1000, 31);
            this.menuChooseSymptom.TabIndex = 1;
            this.menuChooseSymptom.Text = "menuUserHome";
            // 
            // HomeSymptomToolStripMenuItem
            // 
            this.HomeSymptomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSymptomToolStripMenuItem.Name = "HomeSymptomToolStripMenuItem";
            this.HomeSymptomToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.HomeSymptomToolStripMenuItem.Text = "Pocetna";
            this.HomeSymptomToolStripMenuItem.Click += new System.EventHandler(this.HomeSymptomToolStripMenuItem_Click);
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
            this.LogOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(650, 0, 0, 0);
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.LogOutToolStripMenuItem.Text = "Odjava";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // radioButtonS1
            // 
            this.radioButtonS1.AutoSize = true;
            this.radioButtonS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS1.Location = new System.Drawing.Point(41, 110);
            this.radioButtonS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS1.Name = "radioButtonS1";
            this.radioButtonS1.Size = new System.Drawing.Size(183, 22);
            this.radioButtonS1.TabIndex = 2;
            this.radioButtonS1.TabStop = true;
            this.radioButtonS1.Text = "Suva koža, kosa i nokti";
            this.radioButtonS1.UseVisualStyleBackColor = true;
            // 
            // radioButtonS2
            // 
            this.radioButtonS2.AutoSize = true;
            this.radioButtonS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS2.Location = new System.Drawing.Point(41, 144);
            this.radioButtonS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS2.Name = "radioButtonS2";
            this.radioButtonS2.Size = new System.Drawing.Size(223, 22);
            this.radioButtonS2.TabIndex = 3;
            this.radioButtonS2.TabStop = true;
            this.radioButtonS2.Text = "Glavobolja, umor i pospanost";
            this.radioButtonS2.UseVisualStyleBackColor = true;
            // 
            // radioButtonS3
            // 
            this.radioButtonS3.AutoSize = true;
            this.radioButtonS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS3.Location = new System.Drawing.Point(41, 178);
            this.radioButtonS3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS3.Name = "radioButtonS3";
            this.radioButtonS3.Size = new System.Drawing.Size(120, 22);
            this.radioButtonS3.TabIndex = 4;
            this.radioButtonS3.TabStop = true;
            this.radioButtonS3.Text = "Bol u kostima";
            this.radioButtonS3.UseVisualStyleBackColor = true;
            // 
            // radioButtonS4
            // 
            this.radioButtonS4.AutoSize = true;
            this.radioButtonS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS4.Location = new System.Drawing.Point(41, 211);
            this.radioButtonS4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS4.Name = "radioButtonS4";
            this.radioButtonS4.Size = new System.Drawing.Size(201, 22);
            this.radioButtonS4.TabIndex = 5;
            this.radioButtonS4.TabStop = true;
            this.radioButtonS4.Text = "Slab imunitet, malaksalost";
            this.radioButtonS4.UseVisualStyleBackColor = true;
            // 
            // radioButtonS5
            // 
            this.radioButtonS5.AutoSize = true;
            this.radioButtonS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS5.Location = new System.Drawing.Point(41, 245);
            this.radioButtonS5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS5.Name = "radioButtonS5";
            this.radioButtonS5.Size = new System.Drawing.Size(170, 22);
            this.radioButtonS5.TabIndex = 6;
            this.radioButtonS5.TabStop = true;
            this.radioButtonS5.Text = "Koža bez elasticnosti";
            this.radioButtonS5.UseVisualStyleBackColor = true;
            // 
            // radioButtonS6
            // 
            this.radioButtonS6.AutoSize = true;
            this.radioButtonS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS6.Location = new System.Drawing.Point(41, 279);
            this.radioButtonS6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS6.Name = "radioButtonS6";
            this.radioButtonS6.Size = new System.Drawing.Size(136, 22);
            this.radioButtonS6.TabIndex = 7;
            this.radioButtonS6.TabStop = true;
            this.radioButtonS6.Text = "Loša krvna slika";
            this.radioButtonS6.UseVisualStyleBackColor = true;
            // 
            // radioButtonS7
            // 
            this.radioButtonS7.AutoSize = true;
            this.radioButtonS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS7.Location = new System.Drawing.Point(41, 312);
            this.radioButtonS7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonS7.Name = "radioButtonS7";
            this.radioButtonS7.Size = new System.Drawing.Size(112, 22);
            this.radioButtonS7.TabIndex = 8;
            this.radioButtonS7.TabStop = true;
            this.radioButtonS7.Text = "Oslabljen vid";
            this.radioButtonS7.UseVisualStyleBackColor = true;
            // 
            // buttonSuggestVitamin
            // 
            this.buttonSuggestVitamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuggestVitamin.Location = new System.Drawing.Point(63, 375);
            this.buttonSuggestVitamin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSuggestVitamin.Name = "buttonSuggestVitamin";
            this.buttonSuggestVitamin.Size = new System.Drawing.Size(218, 59);
            this.buttonSuggestVitamin.TabIndex = 9;
            this.buttonSuggestVitamin.Text = "Predlozi vitamin";
            this.buttonSuggestVitamin.UseVisualStyleBackColor = true;
            this.buttonSuggestVitamin.Click += new System.EventHandler(this.buttonSuggestVitamin_Click);
            // 
            // labelChooseSymptom
            // 
            this.labelChooseSymptom.AutoSize = true;
            this.labelChooseSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseSymptom.Location = new System.Drawing.Point(35, 62);
            this.labelChooseSymptom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseSymptom.Name = "labelChooseSymptom";
            this.labelChooseSymptom.Size = new System.Drawing.Size(154, 25);
            this.labelChooseSymptom.TabIndex = 10;
            this.labelChooseSymptom.Text = "Izaberi simptom:";
            // 
            // listBoxSuggestedVitamin
            // 
            this.listBoxSuggestedVitamin.FormattingEnabled = true;
            this.listBoxSuggestedVitamin.ItemHeight = 20;
            this.listBoxSuggestedVitamin.Location = new System.Drawing.Point(549, 78);
            this.listBoxSuggestedVitamin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSuggestedVitamin.Name = "listBoxSuggestedVitamin";
            this.listBoxSuggestedVitamin.Size = new System.Drawing.Size(375, 144);
            this.listBoxSuggestedVitamin.TabIndex = 11;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(620, 300);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(229, 54);
            this.buttonOrder.TabIndex = 12;
            this.buttonOrder.Text = "Poruci";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(616, 250);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(107, 18);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Kolicina (1-10):";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(758, 249);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(90, 27);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // ChooseSymptom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.listBoxSuggestedVitamin);
            this.Controls.Add(this.labelChooseSymptom);
            this.Controls.Add(this.buttonSuggestVitamin);
            this.Controls.Add(this.radioButtonS7);
            this.Controls.Add(this.radioButtonS6);
            this.Controls.Add(this.radioButtonS5);
            this.Controls.Add(this.radioButtonS4);
            this.Controls.Add(this.radioButtonS3);
            this.Controls.Add(this.radioButtonS2);
            this.Controls.Add(this.radioButtonS1);
            this.Controls.Add(this.menuChooseSymptom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseSymptom";
            this.Text = "ChooseSymptom";
            this.Load += new System.EventHandler(this.ChooseSymptom_Load);
            this.menuChooseSymptom.ResumeLayout(false);
            this.menuChooseSymptom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuChooseSymptom;
        private System.Windows.Forms.ToolStripMenuItem HomeSymptomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VitaminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonS1;
        private System.Windows.Forms.RadioButton radioButtonS2;
        private System.Windows.Forms.RadioButton radioButtonS3;
        private System.Windows.Forms.RadioButton radioButtonS4;
        private System.Windows.Forms.RadioButton radioButtonS5;
        private System.Windows.Forms.RadioButton radioButtonS6;
        private System.Windows.Forms.RadioButton radioButtonS7;
        private System.Windows.Forms.Button buttonSuggestVitamin;
        private System.Windows.Forms.Label labelChooseSymptom;
        private System.Windows.Forms.ListBox listBoxSuggestedVitamin;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}