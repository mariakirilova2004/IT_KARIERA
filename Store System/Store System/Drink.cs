using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Drink :Product
    {
    public Drink(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
        if(percentageMarkup > 200) throw new ArgumentException("Drink percentage markup cannot be above 200%!");
    }
    public override string ToString()
    {
        return base.ToString();
    }
}