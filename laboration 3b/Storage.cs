using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Laboration_3b
{
    class Storage
    {
        private int totalProducts;
        List<Product> productList;

        public string errorMsg;

        public Storage()      
        {
            this.totalProducts = 0;
            this.productList = new List<Product>();

        }
        public void setTotalProducts(int amount)
        {
            this.totalProducts = amount;
        }
        public void setProductArray()
        {
            productList.Add(new Product());
        }
        public int getTotalProductucs()
        {
            return this.totalProducts;
        }
        public List<Product> getProductArray()
        {
            return this.productList;
        }

        public void addNewProduct(string n, double p, int i, int a)
        {
            int trigger = 0;

            if(totalProducts == 0)  // om listan inte har något innehåll, så inieras den.
            {
                this.productList = new List<Product>();
            }

            for (int f = 0; f < getTotalProductucs(); f++)  
            {
                if (productList[f].getId() == i)
                {
                    errorMsg = "Produkten finns redan...";
                    trigger = 1;
                }
               
            }

            if (trigger == 0) // om produkten inte finns i listan så läggs den till
            {
                productList.Add(new Product(n, p, i, a));       
                errorMsg = "Produkten lades till...";
                totalProducts++;
            }
            
          
        }
        public void removeProduct(int i)
        {
            deleteProductForm delForm = new deleteProductForm();  //gör en form så att vi kan få svars allternativ från användaren
            int trigger = 0;
            bool respondValue;

            for (int f = 0; f < getTotalProductucs(); f++)
            {
                if (productList[f].getId() == i)
                {
                    trigger = 1;
                    if (productList[f].getAmount() > 0) // om det finns fler mer varor än 0 kvar hos produkten
                    {
                                       
                        respondValue = delForm.getReply();
                        if (respondValue)           // om kunden ändå vill ta bort produkten
                        {
                            productList.RemoveAt(f);
                            errorMsg = "Produkten är bortagen...";
                            totalProducts--;
                        }
                        else
                        {
                            errorMsg = "Produkten är inte bortagen...";
                        }
                   
                    }
                    else
                    {
                        productList.RemoveAt(f);            //tar bort produkten om det inte finns något antal kvar
                        errorMsg = "Produkten är bortagen...";
                        totalProducts--;
                    }
                        
                }
                else if (trigger == 0)
                {
                    errorMsg = "Produkten finns inte...";
                }
                   
            }
        }
        public void addItemsToProduct(int i, int a)       
        {
            int trigger = 0;
            for (int f = 0; f < getTotalProductucs(); f++)
            {
                if (productList[f].getId() == i)
                {
                    int newAmount = (a + productList[f].getAmount());
                    productList[f].setAmount(newAmount);
                    trigger = 1;
                    errorMsg = "Lagersaldo ökat för produkten...";
                }
            }
            if (trigger == 0 && a > 0)      //produkten finns inte sortimentet
            {   
                addNewProductForm form = new addNewProductForm();
                form.storage = this;
                form.addNewItem(i, a);
                form.Close();
                
            }
        }
        public void removeItemsFromProduct(int i, int a)
        {
            int trigger = 0;          

            for (int f = 0; f < getTotalProductucs(); f++)
            {
                if (productList[f].getId() == i)
                {
                    trigger = 1;
                    int newAmount = (productList[f].getAmount() - a);   //inte tillräckligt antal av produkten i lager, köpet avbryts
                    if (newAmount < 0)
                    {
                        errorMsg = "Inte tillräckligt i lager...";
                    }
                    else
                    {
                        productList[f].setAmount(newAmount);
                        errorMsg = "Produkter har blivit sålda...";
                    }
                }
                else if (trigger == 0)
                {
                    errorMsg = "Produkten finns inte...";
                }

            }
        }

        public string listAllProducts(int f)            //skriver ut hela listan
        {   
            string objectInfo = ("Id: " + productList[f].getId().ToString() +", Namn: "+ productList[f].getName() +
                    ", Pris: "+productList[f].getPrice().ToString() + ", Antal: " + productList[f].getAmount().ToString());
           
            return objectInfo;
     
        }


        public void updateTxtFile(Storage storage)
        {
            string stringFile = "";
            List<Product> tempList = storage.getProductArray();
            for (int i = 0; i < storage.getTotalProductucs(); i++)
            {
                stringFile += (tempList[i].getName() + "," + (tempList[i].getPrice()).ToString() + "," + (tempList[i].getId()).ToString() + "," + (tempList[i].getAmount()).ToString() + "\n");
            }       // denna metod uppdaterar textfilen/csv products varje gång efter användaren har på något sätt 
                    // uppdaterat produktregistret.
            File.WriteAllText("products.txt", stringFile);
            File.WriteAllText("products.csv", stringFile);
        }


    }


  
}
