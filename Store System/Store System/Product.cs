using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Product
    {
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Product name must not be null or empty!");
            }
            else name = value;
        }
    }
    private int qantity;

    public int Quantity
    {
        get { return qantity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Quantity cannot be less or equal to 0!");
            }
            else qantity = value;
        }
    }

    private double deliverPrice;

        public double DeliverPrice
        {
            get { return deliverPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Deliver price cannot be less or equal to 0!");
                }
                else deliverPrice = value;
            }
        }

    private double percentageMarkup;

    public double PercentageMarkup
    {
        get { return percentageMarkup; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
            }
            else percentageMarkup = value;
        }
    }

    public double FinalPrice
        {
            get { return this.DeliverPrice + (this.DeliverPrice * this.PercentageMarkup / 100); }
        }

        public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.DeliverPrice = deliverPrice;
            this.PercentageMarkup = percentageMarkup;
        }

        public override string ToString()
        {
            string rez = $"****Product: {Name} <{Quantity}>\n****Deliver Price: {DeliverPrice:0.00}\n****Percentage Markup: {PercentageMarkup}\n****Final Price: {FinalPrice:0.00}";
            return rez;
        }
    }
