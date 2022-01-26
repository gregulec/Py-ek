using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyłek
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Audi();
            car = new Air(car);
            Console.WriteLine(car.description());
            car = new HotSits(car);
            Console.WriteLine(car.description());
            Console.ReadLine();
        }
    }
}
