namespace Laboration_3b
{
    partial class addNewProductForm
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
            this.addProTxt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProTxt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProTxt3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProTxt4 = new System.Windows.Forms.TextBox();
            this.addProBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProTxt1
            // 
            this.addProTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProTxt1.Location = new System.Drawing.Point(80, 12);
            this.addProTxt1.Name = "addProTxt1";
            this.addProTxt1.Size = new System.Drawing.Size(82, 20);
            this.addProTxt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pris:";
            // 
            // addProTxt2
            // 
            this.addProTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProTxt2.Location = new System.Drawing.Point(203, 12);
            this.addProTxt2.Name = "addProTxt2";
            this.addProTxt2.Size = new System.Drawing.Size(82, 20);
            this.addProTxt2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            // 
            // addProTxt3
            // 
            this.addProTxt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProTxt3.Location = new System.Drawing.Point(318, 12);
            this.addProTxt3.Name = "addProTxt3";
            this.addProTxt3.Size = new System.Drawing.Size(82, 20);
            this.addProTxt3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antal:";
            // 
            // addProTxt4
            // 
            this.addProTxt4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProTxt4.Location = new System.Drawing.Point(448, 12);
            this.addProTxt4.Name = "addProTxt4";
            this.addProTxt4.Size = new System.Drawing.Size(82, 20);
            this.addProTxt4.TabIndex = 6;
            // 
            // addProBtn
            // 
            this.addProBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProBtn.Location = new System.Drawing.Point(562, 5);
            this.addProBtn.Name = "addProBtn";
            this.addProBtn.Size = new System.Drawing.Size(89, 34);
            this.addProBtn.TabIndex = 8;
            this.addProBtn.Text = "Lägg till";
            this.addProBtn.UseVisualStyleBackColor = true;
            this.addProBtn.Click += new System.EventHandler(this.addProBtn_Click);
            // 
            // addNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 49);
            this.Controls.Add(this.addProBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addProTxt4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProTxt3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProTxt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProTxt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addNewProductForm";
            this.Text = "Lägg till produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProTxt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addProTxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProTxt3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProTxt4;
        private System.Windows.Forms.Button addProBtn;
    }
}