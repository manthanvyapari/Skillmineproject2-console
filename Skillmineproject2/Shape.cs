using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    abstract public class Shape
    {
        public abstract void CalculateArea();

    }

    public class Circle : Shape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"area of circle is {area}";
        }

    }

    public class Ractangle : Shape
    {
        private int l;
        private int w;
        private double area;

        public Ractangle(int l,int w)
        {
            

            this.l = l;
            this.w = w;
        }
        public override void CalculateArea()
        {
            area = l * w;
        }
        public override string ToString()
        {
            return $"area of rectangle {area}";
        }
    }
          
}





//ABSTRACT CLASS

//Circle c = new Circle(6);
//c.CalculateArea();
//Console.WriteLine(c);

//Ractangle r = new Ractangle(10, 20);
//r.CalculateArea();
//Console.WriteLine(r);
