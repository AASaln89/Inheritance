using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    sealed class MultiBuild:Build
    {
        int floor;

        public MultiBuild(string adress, double length, double width, double heigth, int floor)
            : base(adress, length, width, heigth)
        {
            this.floor = floor;
        }

        public string Print()
        {
            string result = base.Print();
            result += $" {floor}";
            return result;
        }
    }
}
