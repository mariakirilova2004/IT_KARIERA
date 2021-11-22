using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store name must not be null or empty!");
                }
                else name = value;
            }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store type must not be null or empty!");
                }
                else type = value;
            }
        }

        private double revenue;

        public double Revenue
        {
            get { return revenue; }
            set { revenue = value; }
        }

        public Store(string name, string type)
        {
            Name = name;
            Type = type;
            this.availableProducts = new List<Product>();
        }

    private List<Product> availableProducts;

        public bool ReceiveProduct(Product product)
        {
        foreach (var item in availableProducts)
        {
            if (item.Name == product.Name) return false;
        }
            availableProducts.Add(product);
            return true;
        }

        public bool SellProduct(string name, int quantity)
        {
            for (int i = 0; i < availableProducts.Count; i++)
            {
                if (name == availableProducts[i].Name && availableProducts[i].Quantity >= quantity)
                {
                if (availableProducts[i].Quantity - quantity == 0)
                {
                    this.Revenue += quantity * availableProducts[i].FinalPrice;
                    availableProducts.RemoveAt(i);
                }
                else
                {
                    availableProducts[i].Quantity -= quantity;
                    this.Revenue += quantity * availableProducts[i].FinalPrice;
                }
                return true;
                }
            }
            return false;
        }

        public Product GetProduct(string name)
        {
            for (int i = 0; i < availableProducts.Count; i++)
            {
                if (name == availableProducts[i].Name)
                {
                    return availableProducts[i];
                }
            }
            return null;
        }

        public override string ToString()
        {
            string rez = $"****Store: {Name} <{Type}>\n****Available products: <{availableProducts.Count}>\n{PrintProducts(availableProducts)}****Revenue: <{Revenue:0.00}BGN>";
            return rez;
        }

        private string PrintProducts(List<Product> list)
        {
            string rezp = "";
            for (int i = 0; i < availableProducts.Count; i++)
            {
                rezp += $"****** {list[i].Name} ({list[i].Quantity})\n";
            }
            return rezp;
        }
    }