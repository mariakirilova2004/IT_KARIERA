using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Car carCurrent = new Car();
                Engine engineCurrent = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Product productCurrent = new Product(int.Parse(input[3]), input[4]);
                Tire tireCurrent1 = new Tire(double.Parse(input[5]), int.Parse(input[6]));
                Tire tireCurrent2 = new Tire(double.Parse(input[7]), int.Parse(input[8]));
                Tire tireCurrent3 = new Tire(double.Parse(input[9]), int.Parse(input[10]));
                Tire tireCurrent4 = new Tire(double.Parse(input[11]), int.Parse(input[12]));
                carCurrent.Model = input[0];
                carCurrent.engine = engineCurrent;
                carCurrent.product = productCurrent;
                carCurrent.tire1 = tireCurrent1;
                carCurrent.tire2 = tireCurrent2;
                carCurrent.tire3 = tireCurrent3;
                carCurrent.tire4 = tireCurrent4;
                cars.Add(carCurrent);
            }
            string command = Console.ReadLine();
            List<Car> Answear = new List<Car>();
            if(command=="fragile")
            {
                foreach (var car in cars)
                {
                    if (car.product.Type == "fragile" && (car.tire1.Pressure + car.tire2.Pressure + car.tire3.Pressure + car.tire4.Pressure) / 4 < 1) Answear.Add(car);
                }
            }
            if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.product.Type == "flamable" && car.engine.Power > 250) Answear.Add(car);
                }
            }
            foreach (var ans  in Answear)
            {
                Console.WriteLine(ans.Model);
            }
            Console.ReadKey();
        }
    }
}
