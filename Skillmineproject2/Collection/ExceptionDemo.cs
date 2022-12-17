using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
   public class ExceptionDemo
    {
        public class Stud
        {
            private int marks;
            private string name;
          
            public void AcceptMarks(int marks)
            {
                if (marks > 100)
                {
                    throw new MarksException("Marks can not be greater than 100");
                }
                else
                {
                    this.marks = marks;
                }
            }

            public void AcceptName(string name)
            {
                if (name== null)
                {
                    throw new Exception("Name is Required");
                }
                else
                {
                    this.name = name;
                }
            }


        }

        
        public class Program
        {

            static void Main(string[] args)
            {
                Stud s = new Stud();
                try
                {
                    s.AcceptMarks(101);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Stud s1 = new Stud();

                try
                {
                    s1.AcceptName( null);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                



            }


        }

    }
}
