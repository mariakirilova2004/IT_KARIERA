using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class StoreController
    {
        static List<Store> stores = new List<Store>();
        public string CreateStore(List<string> args)
        {
            Store store = new Store(args[0], args[1]);
            foreach (var item in stores)
            {
                    if(item.Name == args[0] && item.Type == args[1]) return $"Store {store.Name} is already registered!";
            }
            stores.Add(store);
            return $"Store {store.Name} was successfully registerd in the system!";
        }

        public string ReceiveProduct(List<string> args)
        {
            if(args[0] == "Food")
            {
                Product pr = new Food(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
                int control = 0;
                for (int i = 0; i < stores.Count; i++)
                {
                    if (stores[i].Name == args[5])
                    {
                        control++;
                        if (stores[i].ReceiveProduct(pr)) return $"Product {pr.Name} was successfully delivered to {stores[i].Name}!";
                        return $"Product {pr.Name} was already delivered to {stores[i].Name}!";
                    }
                }
                if (control == 0) return $"Invalid Store: {args[5]}. Cannot find it in system!";
            }
            else if (args[0] == "Drink")
            {
                Product pr = new Drink(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
                int control = 0;
                for (int i = 0; i < stores.Count; i++)
                {
                    if (stores[i].Name == args[5])
                    {
                        control++;
                        if (stores[i].ReceiveProduct(pr)) return $"Product {pr.Name} was successfully delivered to {stores[i].Name}!";
                        return $"Product {pr.Name} was already delivered to {stores[i].Name}!";
                    }
                }
                if (control == 0) return $"Invalid Store: {args[5]}. Cannot find it in system!";
            }
            return $"Product {args[0]} is invalid!";
        }

        public string SellProduct(List<string> args)
        {
            for (int i = 0; i < stores.Count; i++)
            {
                if (stores[i].Name == args[2])
                {
                    if (stores[i].SellProduct(args[0], int.Parse(args[1]))) return $"Product {args[0]} was successfully bought from {args[2]}!";
                    else return $"Product {args[0]} was already sold out!";
                }
            }
            return $"Invalid Store: {args[2]}. Cannot find it in system!";
        }

        public string StoreInfo(List<string> args)
        {
            for (int i = 0; i < stores.Count; i++)
            {
                if (stores[i].Name == args[0])
                {
                    return stores[i].ToString();
                }
            }
            return $"Invalid Store: {args[0]}. Cannot find it in system!";
        }

        public string Shutdown()
        {
            stores = stores.OrderByDescending(x => x.Revenue).ThenBy(x => x.Name).ToList();
            string rez;
            string otg = "";
            foreach (var item in stores)
            {
                otg += item.ToString();
                otg += "\n";
            }
            rez = $"Stores: {stores.Count}\n{otg}System Store Revenues: {stores.Sum(x => x.Revenue):0.00}BGN";
            return rez;
        }
    }
