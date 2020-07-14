namespace Laboration_3b
{
    partial class mediabutikID
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LagerLista = new System.Windows.Forms.ListBox();
            this.AddDeliveryBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.listProductsBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButikLista = new System.Windows.Forms.ListBox();
            this.sellProductBtn = new System.Windows.Forms.Button();
            this.listProductsStoreBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exportBtn);
            this.tabPage1.Controls.Add(this.LagerLista);
            this.tabPage1.Controls.Add(this.AddDeliveryBtn);
            this.tabPage1.Controls.Add(this.removeProductBtn);
            this.tabPage1.Controls.Add(this.addProductBtn);
            this.tabPage1.Controls.Add(this.listProductsBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lager";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LagerLista
            // 
            this.LagerLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LagerLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LagerLista.FormattingEnabled = true;
            this.LagerLista.ItemHeight = 18;
            this.LagerLista.Location = new System.Drawing.Point(181, 3);
            this.LagerLista.Name = "LagerLista";
            this.LagerLista.Size = new System.Drawing.Size(813, 1066);
            this.LagerLista.TabIndex = 5;
            // 
            // AddDeliveryBtn
            // 
            this.AddDeliveryBtn.Location = new System.Drawing.Point(6, 120);
            this.AddDeliveryBtn.Name = "AddDeliveryBtn";
            this.AddDeliveryBtn.Size = new System.Drawing.Size(172, 32);
            this.AddDeliveryBtn.TabIndex = 4;
            this.AddDeliveryBtn.Text = "Lägg till leverans";
            this.AddDeliveryBtn.UseVisualStyleBackColor = true;
            this.AddDeliveryBtn.Click += new System.EventHandler(this.AddDeliveryBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.Location = new System.Drawing.Point(6, 82);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(172, 32);
            this.removeProductBtn.TabIndex = 3;
            this.removeProductBtn.Text = "Ta bort produkt";
            this.removeProductBtn.UseVisualStyleBackColor = true;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(6, 44);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(172, 32);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Lägg till produkt";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // listProductsBtn
            // 
            this.listProductsBtn.Location = new System.Drawing.Point(6, 6);
            this.listProductsBtn.Name = "listProductsBtn";
            this.listProductsBtn.Size = new System.Drawing.Size(172, 32);
            this.listProductsBtn.TabIndex = 1;
            this.listProductsBtn.Text = "Lista produkter";
            this.listProductsBtn.UseVisualStyleBackColor = true;
            this.listProductsBtn.Click += new System.EventHandler(this.listProductsBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButikLista);
            this.tabPage2.Controls.Add(this.sellProductBtn);
            this.tabPage2.Controls.Add(this.listProductsStoreBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Butik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButikLista
            // 
            this.ButikLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButikLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ButikLista.FormattingEnabled = true;
            this.ButikLista.ItemHeight = 18;
            this.ButikLista.Location = new System.Drawing.Point(181, 3);
            this.ButikLista.Name = "ButikLista";
            this.ButikLista.Size = new System.Drawing.Size(813, 525);
            this.ButikLista.TabIndex = 8;
            // 
            // sellProductBtn
            // 
            this.sellProductBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sellProductBtn.Location = new System.Drawing.Point(6, 44);
            this.sellProductBtn.Name = "sellProductBtn";
            this.sellProductBtn.Size = new System.Drawing.Size(172, 32);
            this.sellProductBtn.TabIndex = 7;
            this.sellProductBtn.Text = "Sälj Produkt";
            this.sellProductBtn.UseVisualStyleBackColor = true;
            this.sellProductBtn.Click += new System.EventHandler(this.sellProductBtn_Click);
            // 
            // listProductsStoreBtn
            // 
            this.listProductsStoreBtn.Location = new System.Drawing.Point(6, 6);
            this.listProductsStoreBtn.Name = "listProductsStoreBtn";
            this.listProductsStoreBtn.Size = new System.Drawing.Size(172, 32);
            this.listProductsStoreBtn.TabIndex = 6;
            this.listProductsStoreBtn.Text = "Lista produkter";
            this.listProductsStoreBtn.UseVisualStyleBackColor = true;
            this.listProductsStoreBtn.Click += new System.EventHandler(this.listProductsStoreBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(6, 158);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(172, 32);
            this.exportBtn.TabIndex = 6;
            this.exportBtn.Text = "Exportera Produktregister";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // mediabutikID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "mediabutikID";
            this.Text = "Mediabutik";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddDeliveryBtn;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button listProductsBtn;
        private System.Windows.Forms.Button sellProductBtn;
        private System.Windows.Forms.Button listProductsStoreBtn;
        private System.Windows.Forms.ListBox LagerLista;
        private System.Windows.Forms.ListBox ButikLista;
        private System.Windows.Forms.Button exportBtn;
    }
}

