using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес1");
            string adress1 = Console.ReadLine();
            Console.WriteLine("Введите адрес2");
            string adress2 = Console.ReadLine();
            Console.WriteLine("Введите этажность");
            int floor = Convert.ToInt32(Console.ReadLine());
            Build build = new Build (adress1, 2000, 2000, 6000);
            Console.WriteLine(build.Print());
            MultiBuild MBuild = new MultiBuild (adress2, 2000, 2000, 6000, floor);
            Console.WriteLine(MBuild.Print());
            Console.ReadKey();
        }
    }
}
