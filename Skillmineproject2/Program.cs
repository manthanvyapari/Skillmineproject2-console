using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // INHARITANCE



            //Manager m1 = new Manager(102, "Rahul", 21000, 1500);
            //Manager m2 = new Manager(103, "Kishor", 120000, 1540);

            //m1.CalculateSallary();
            //m2.CalculateSallary();


            //Console.WriteLine(m1);
            //Console.WriteLine(m2);

            //SalesManager sm = new SalesManager(5545, "manthan", 10000, 543, 2000, 1000);
            //SalesManager sm1 = new SalesManager(1646, "Ajay", 120000, 5487, 1200, 45554);

//------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------

            //ABSTRACT CLASS

            Circle c = new Circle(6);
            c.CalculateArea();
            Console.WriteLine(c);

            Ractangle r = new Ractangle(10, 20);
            r.CalculateArea();
            Console.WriteLine(r);


//--------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------





        }
    }

 


}
