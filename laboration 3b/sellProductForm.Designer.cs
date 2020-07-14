namespace Laboration_3b
{
    partial class sellProductForm
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
            this.sellBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(159, 71);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(100, 36);
            this.sellBtn.TabIndex = 0;
            this.sellBtn.Text = "Sälj";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkt Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Antal:";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(15, 25);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idTxtBox.TabIndex = 3;
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(15, 72);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountTxtBox.TabIndex = 4;
            this.amountTxtBox.TextChanged += new System.EventHandler(this.amountTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Totalt pris: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(189, 28);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 7;
            // 
            // sellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(285, 121);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sellProductForm";
            this.Text = "Försäljning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceLabel;
    }
}