using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Build
    {
        string adress;
        double length;
        double width;
        double heigth;
        double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <1)
                    length = 1;
                else
                    length = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 1)
                    width = 1;
                else
                    width = value;
            }
        }
        double Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                if (value < 1)
                    heigth = 1;
                else
                    heigth = value;
            }
        }

        public Build(string adress, double length, double width, double heigth)
        {
            this.adress = adress;
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }
        public string Print()
        {
            return $"{adress} {length} {width} {heigth}";
        }
    }
}
