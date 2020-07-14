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
    partial class deleteProductForm : Form
    {
        public deleteProductForm()
        {
            InitializeComponent();
        }

        public Storage storage
        {
            get;
            set;
        }

        public bool getReply()          //ställer fråga till användaren
        {
            bool value = false;
            var result = MessageBox.Show("Det finns varor kvar av produkten, vill du ta bort ändå?", "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                    );
            if (result == DialogResult.Yes)
            {
                value = true;
            }
            else if (result == DialogResult.No)
            {
                value = false;
            }
            return value;
        }

        private void deleteBtn_Click(object sender, EventArgs e)        //tar bort produkten från sortiment
        {
            try
            {
                storage.removeProduct(int.Parse(deleteTxtBox.Text));
                MessageBox.Show(storage.errorMsg);
                this.Close();
            }
            catch
            {
                deleteTxtBox.Text = "invalid input";
            }
        }

      
    }
}
