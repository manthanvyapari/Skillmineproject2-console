using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.ArrayC
{
   public  class Astudent
    { 
        int rollno;
         string name;
        int marks;
        long mobileno;

        public Astudent(int rollno,string name,int marks,long mobileno)
        {
            this.rollno = rollno;
            this.name = name;
            this.marks = marks;
            this.mobileno = mobileno;
        }
        public override string ToString()
        {
            return $"Student roll no---{rollno},Student name-----{name},Student marks------{marks},Student mobile no{mobileno}";
        }

        static void Main(string[] args)
        {
            Astudent[] s = new Astudent[]
            {
                new Astudent(1,"Akshay",89,7554846526),
                new Astudent(2,"Chinntu",66,5487952156),

            };
          //   foreach( Astudent item in s)
            {
                Console.WriteLine(s);
            }


        }
    }
}
