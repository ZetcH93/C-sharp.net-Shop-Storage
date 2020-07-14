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
    partial class sellProductForm : Form
    {
        public sellProductForm()
        {
            InitializeComponent();
        }
        public Storage storage
        {
            get;
            set;
        }

        public void setPrice()      // räknar ut hur mycket köpet kommer kosta baserat på antalet för just den produkten
        {
            List<Product> list = new List<Product>();
            list = storage.getProductArray();
            double totalPrice = 0.0;
            try
            {
                for (int i = 0; i < (storage.getTotalProductucs()); i++)
                {
                    if (list[i].getId() == (int.Parse(idTxtBox.Text)))
                    {
                        totalPrice = (double.Parse(amountTxtBox.Text) * list[i].getPrice());
                    }
                }

                priceLabel.Text = (totalPrice.ToString() + " SEK");
            }
            catch
            {
                amountTxtBox.Text = "invalid input";
            }
        }
        private void sellBtn_Click(object sender, EventArgs e)      // tar bort x antal från produkten
        {  try
            {
                storage.removeItemsFromProduct(int.Parse(idTxtBox.Text), int.Parse(amountTxtBox.Text));
                MessageBox.Show(storage.errorMsg);
                this.Close();
            }
            catch
            {
                idTxtBox.Text = "invalid input";
                amountTxtBox.Text = "invalid input";
            }
        }

        private void amountTxtBox_TextChanged(object sender, EventArgs e)   //gör så att labelen uppdateras så fort ändringar görs i amount textboxen
        {
            setPrice();
        }

    }
}
