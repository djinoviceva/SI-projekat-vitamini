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
            this.SuspendLayout();
            // 
            // labelConfirmOrder
            // 
            this.labelConfirmOrder.AutoSize = true;
            this.labelConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmOrder.Location = new System.Drawing.Point(277, 27);
            this.labelConfirmOrder.Name = "labelConfirmOrder";
            this.labelConfirmOrder.Size = new System.Drawing.Size(222, 29);
            this.labelConfirmOrder.TabIndex = 0;
            this.labelConfirmOrder.Text = "Potvrda porudzbine";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(297, 340);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(174, 47);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Potvrdi";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.ItemHeight = 16;
            this.listBoxCustomer.Location = new System.Drawing.Point(172, 75);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(437, 164);
            this.listBoxCustomer.TabIndex = 1;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(172, 258);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(436, 52);
            this.listBoxOrder.TabIndex = 2;
            // 
            // OrderConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxCustomer);
            this.Controls.Add(this.labelConfirmOrder);
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
    }
}