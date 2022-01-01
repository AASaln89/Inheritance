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
            Build build = new Build ("Москва", 2000, 2000, 6000);
            Console.WriteLine(build.Print());
            MultiBuild MBuild = new MultiBuild ("Москва", 2000, 2000, 6000, 2);
            Console.WriteLine(MBuild.Print());
            Console.ReadKey();
        }
    }
}
