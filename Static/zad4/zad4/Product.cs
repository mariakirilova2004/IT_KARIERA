using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Product
    {
        static List<Product> Products = new List<Product>();
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double br;

        public  double Br
        {
            get { return br; }
            set { br = value; }
        }

        private Product(string barcode, string name, double price, double br)
        {
            Barcode = barcode;
            Name = name;
            Price = price;
            Br = br;
        }

        public void Sell(string barcode, double br)
        {
            foreach (var product in Products)
            {
                if(product.Barcode == barcode)
                {
                    if (product.Br - br < 0) Console.WriteLine("Not enough quantity");
                    else product.Br -= br;
                    break;
                }
            }
        }

        public void Add(string barcode, string name, double price, double br)
        {
            Product p1 = new Product(barcode, name, price, br);
            Products.Add(p1);
        }

        public void Update(string barcode, double br)
        {
            int contr = 0;
            foreach (var product in Products)
            {
                if (product.Barcode == barcode)
                {
                    product.Br += br;
                    contr++;
                    break;
                }
            }
            if (contr == 0) Console.WriteLine("Please add your product first!");
        }
        public void PrintA()
        {
            Products.Sort();
        }
    }
}
