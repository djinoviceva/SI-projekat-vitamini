namespace PresentationLayer
{
    partial class OrderConfirmation
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
            this.labelConfirmOrder = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelConfirmOrder
            // 
            this.labelConfirmOrder.AutoSize = true;
            this.labelConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmOrder.Location = new System.Drawing.Point(346, 24);
            this.labelConfirmOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmOrder.Name = "labelConfirmOrder";
            this.labelConfirmOrder.Size = new System.Drawing.Size(222, 29);
            this.labelConfirmOrder.TabIndex = 0;
            this.labelConfirmOrder.Text = "Potvrda porudzbine";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(376, 459);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(218, 59);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Potvrdi";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.ItemHeight = 20;
            this.listBoxCustomer.Location = new System.Drawing.Point(214, 64);
            this.listBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(545, 124);
            this.listBoxCustomer.TabIndex = 1;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 20;
            this.listBoxOrder.Location = new System.Drawing.Point(214, 235);
            this.listBoxOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(544, 124);
            this.listBoxOrder.TabIndex = 2;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(209, 206);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(98, 20);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Porudzbina:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(506, 388);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(70, 20);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Ukupno:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(600, 381);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(158, 27);
            this.textBoxTotal.TabIndex = 6;
            // 
            // OrderConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxCustomer);
            this.Controls.Add(this.labelConfirmOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderConfirmation";
            this.Text = "Potvrda porudzbine";
            this.Load += new System.EventHandler(this.OrderConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfirmOrder;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}