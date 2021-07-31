using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment2
{
    class Circle
    {
        private double radius;
        private double area;
        public double _area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        public double _radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }
        public void calculateArea()
        {
            this.area = Convert.ToDouble(Math.PI) * this.radius * this.radius;
        }
        public static Circle operator +(Circle a, Circle b)
        {
            Circle newCircleadd = new Circle();
            newCircleadd._radius = a._radius + b._radius;
            newCircleadd.calculateArea();
            a.calculateArea();
            b.calculateArea();
            newCircleadd.area = a.area + b.area;
            return newCircleadd;
        }
        public static Circle operator -(Circle c, Circle d)
        {
            Circle newCirclesub = new Circle();
            newCirclesub.radius = c.radius - d.radius;
            newCirclesub.calculateArea();
            c.calculateArea();
            d.calculateArea();
            newCirclesub.area = c.area - d.area;
            return newCirclesub;
        }
    }
}
