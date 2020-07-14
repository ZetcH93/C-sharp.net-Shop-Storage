using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Laboration_3b
{
        
    partial class mediabutikID : Form
    {
        Storage storage = new Storage();

        public mediabutikID()
        {   
            InitializeComponent();
            initiateList();    // listan fylls med data från textfil


        }

        private void addProductBtn_Click(object sender, EventArgs e)        //lägg till ny produkt
        {      
            
            addNewProductForm form = new addNewProductForm();
            form.storage = storage;
            form.ShowDialog();
            storage.updateTxtFile(storage);
        }

        private void AddDeliveryBtn_Click(object sender, EventArgs e)      //lägg till items till produkt
        {
            addDeliveryForm form = new addDeliveryForm();
            form.storage = storage;
            form.ShowDialog();
            storage.updateTxtFile(storage);

        }

      
        private void listProductsBtn_Click(object sender, EventArgs e)      //skriver ut listan
        {
            LagerLista.Items.Clear();
            for (int i = 0; i < storage.getTotalProductucs(); i++)
            {
                LagerLista.Items.Add(storage.listAllProducts(i));

            }
        }

        private void removeProductBtn_Click(object sender, EventArgs e)     //tar bort produkt ur sortiment
        {
            deleteProductForm form = new deleteProductForm();
            form.storage = storage;
            form.ShowDialog();
            storage.updateTxtFile(storage);
        }

        private void listProductsStoreBtn_Click(object sender, EventArgs e)     //skriver ut listan för butiks view
        {
            ButikLista.Items.Clear();
            for (int i = 0; i < storage.getTotalProductucs(); i++)
            {
                ButikLista.Items.Add(storage.listAllProducts(i));

            }
        }

        private void sellProductBtn_Click(object sender, EventArgs e)       // tar bort x antal items från produkt
        {
            sellProductForm form = new sellProductForm();
            form.storage = storage;
            form.ShowDialog();
            storage.updateTxtFile(storage);
        }

        public void initiateList()          // skriver in data från textfil
        {
            string[] lines = File.ReadAllLines("products.txt");
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                storage.addNewProduct(fields[0].ToString(), double.Parse(fields[1]), int.Parse(fields[2]), int.Parse(fields[3]));
            }
            
        }

        private void exportBtn_Click(object sender, EventArgs e) // när användaren trycker på export så tas den hit
        {                                                   // här så gör skapar en fil som heter exportProducts.csv
            string aktuellKatalog;                        //som innehåller produktregistret. Om filen redan finns när knappen
            string exportKatalog = "";                    //trycks så skapas en ny.

            aktuellKatalog = Directory.GetCurrentDirectory();           
            exportKatalog = (aktuellKatalog + "/Export/exportProducts.csv");


            string stringFile = "";
            List<Product> tempList = storage.getProductArray();
            for (int i = 0; i < storage.getTotalProductucs(); i++)
            {
               stringFile += (tempList[i].getName() + "," + (tempList[i].getPrice()).ToString() + "," + (tempList[i].getId()).ToString() + "," + (tempList[i].getAmount()).ToString() + "\n");
            }

            if(File.Exists(exportKatalog))
            {
                File.Delete(exportKatalog);
                File.WriteAllText(exportKatalog, stringFile);
            }
            else
            File.WriteAllText(exportKatalog, stringFile);
            
        }
    }
}
