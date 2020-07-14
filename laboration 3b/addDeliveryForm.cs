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
    partial class addDeliveryForm : Form
    {
        public addDeliveryForm()
        {
            InitializeComponent();

        }
        public Storage storage
        {
            get;
            set;
        }

        private void addDeliveryBtn_Click(object sender, EventArgs e)       //lägger till x items till en produkt i sortimentet
        {
            try
            {

                storage.addItemsToProduct(int.Parse(addDeliveryTxt1.Text), int.Parse(addDeliveryTxt2.Text));
                MessageBox.Show(storage.errorMsg);
                this.Close();
            }
            catch
            {
                addDeliveryTxt1.Text = "Invalid Input";
                addDeliveryTxt2.Text = "Invalid Input";
            }

        }
    }
}
