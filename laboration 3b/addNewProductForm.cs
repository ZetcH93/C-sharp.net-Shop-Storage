using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_3b
{
    partial class addNewProductForm : Form
    {
        int trigger = 0;
        public addNewProductForm()
        {
            InitializeComponent();
            
        }

        public Storage storage 
        { 
          get; 
          set; 
        }

        public void addNewItem(int id, int a)      // används då användare lägger till items till en produkt som inte finns
        {
            addProTxt3.Text = id.ToString();
            addProTxt4.Text = a.ToString();
            
            var result = MessageBox.Show("Produkten finns inte, vill du lägga till den?", "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                    );
            if (result == DialogResult.Yes)
            {
                trigger = 1;
                this.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
                storage.errorMsg = "No items added...";
            }
        }

        private void addProBtn_Click(object sender, EventArgs e)    //lägger till ny produkt i listan
        {  try
            {
                storage.addNewProduct(addProTxt1.Text, double.Parse(addProTxt2.Text), int.Parse(addProTxt3.Text), int.Parse(addProTxt4.Text));


                if (trigger != 1)
                {
                    MessageBox.Show(storage.errorMsg);
                }
                if (storage.errorMsg == "Product already exists...")
                {
                    this.Hide();
                    var result = MessageBox.Show("Vill du fortfarande lägga till en ny produkt?", "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                        );
                    if (result == DialogResult.Yes)
                    {      
                        addNewProductForm newForm = new addNewProductForm();    //öppnar ett nytt showdialog fönster för inmatning.
                        newForm.storage = storage;
                        newForm.ShowDialog();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                this.Close();

            }
            catch
            {
                addProTxt1.Text = "Invalid Input";
                addProTxt2.Text = "Invalid Input";
                addProTxt3.Text = "Invalid Input";
                addProTxt4.Text = "Invalid Input";
            }

        }




        
           
       
    }
}
