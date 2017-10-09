using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNum9
{
    class Circle
    {
        private double radius;



        public double Radius

        {

            set { radius = value; }

            get { return radius; }

        }



        public double GetCircumference()

        {

            return (2 * Math.PI * radius);

        }

        public double GetArea()

        {

            return (Math.PI * Math.Pow(radius, 2));

        }





    }
}
