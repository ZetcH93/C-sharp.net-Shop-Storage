namespace Laboration_3b
{
    partial class addDeliveryForm
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
            this.addDeliveryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDeliveryTxt1 = new System.Windows.Forms.TextBox();
            this.addDeliveryTxt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addDeliveryBtn
            // 
            this.addDeliveryBtn.Location = new System.Drawing.Point(225, 7);
            this.addDeliveryBtn.Name = "addDeliveryBtn";
            this.addDeliveryBtn.Size = new System.Drawing.Size(94, 30);
            this.addDeliveryBtn.TabIndex = 0;
            this.addDeliveryBtn.Text = "Lägg till";
            this.addDeliveryBtn.UseVisualStyleBackColor = true;
            this.addDeliveryBtn.Click += new System.EventHandler(this.addDeliveryBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Antal:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // addDeliveryTxt1
            // 
            this.addDeliveryTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addDeliveryTxt1.Location = new System.Drawing.Point(37, 12);
            this.addDeliveryTxt1.Name = "addDeliveryTxt1";
            this.addDeliveryTxt1.Size = new System.Drawing.Size(63, 20);
            this.addDeliveryTxt1.TabIndex = 3;
            // 
            // addDeliveryTxt2
            // 
            this.addDeliveryTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addDeliveryTxt2.Location = new System.Drawing.Point(146, 12);
            this.addDeliveryTxt2.Name = "addDeliveryTxt2";
            this.addDeliveryTxt2.Size = new System.Drawing.Size(73, 20);
            this.addDeliveryTxt2.TabIndex = 5;
            // 
            // addDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 52);
            this.Controls.Add(this.addDeliveryTxt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDeliveryTxt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDeliveryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addDeliveryForm";
            this.Text = "Leveransantal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDeliveryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addDeliveryTxt1;
        private System.Windows.Forms.TextBox addDeliveryTxt2;
    }
}