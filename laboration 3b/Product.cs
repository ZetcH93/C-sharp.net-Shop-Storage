using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboration_3b
{
    class Product
    {
        private string name;
        private double price;
        private int id;
        private int amount;

        public Product()
        {
            this.name = null;
            this.price = 0;
            this.id = 0;
            this.amount = 0;
        }

        public Product(string name, double price, int id, int amount)
        {
            this.name = name;
            this.price = price;
            this.id = id;
            this.amount = amount;
        }

        public void setName(string name) {
            this.name = name;
        }
        public void setPrice(double price) {
            this.price = price;
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setAmount(int amount) {
            this.amount = amount;
        }

        public string getName()
        {
            return this.name;
        }
        public double getPrice()
        {
            return this.price;
        }
        public int getId()
        {
            return this.id;
        }
        public int getAmount()
        {
            return this.amount;
        }
    }
}
