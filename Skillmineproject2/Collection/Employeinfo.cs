using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    public class Employeinfo : IComparable

    {
        private string name;
        private int salary;
        public Employeinfo(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

       

        public int CompareTo(object obj)
        {
            Employeinfo employe4 = (Employeinfo)obj;
            if (this.salary > employe4.salary)
            {
                return 1;
            }
            else if (this.salary < employe4.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return $"{name}--->{salary}";
        }
    }

    public class Company : IEnumerable
    {
        private Employeinfo[] employe;
        public Company()
        {
            employe = new Employeinfo[5];
            employe[0] = new Employeinfo("Manthan", 35000);
            employe[1] = new Employeinfo("Akshay", 30000);
            employe[2] = new Employeinfo("Rahul", 20000);
            employe[3] = new Employeinfo("Sahil", 15000);
            employe[4] = new Employeinfo("Rakesh", 35000);
        }

        public IEnumerator GetEnumerator()
        {
            return employe.GetEnumerator();
        }


        static void Main(string[] args)
        {
            Company c = new Company();
            foreach (Employeinfo e in c)
            {
                Console.WriteLine(e);
            }


            Employeinfo employe1 = new Employeinfo("Manthan", 35000);
            Employeinfo employe2 = new Employeinfo("Akshay", 30000);
            Employeinfo employe3 = new Employeinfo("Rahul", 20000);
            Employeinfo employe4 = new Employeinfo("Sahil", 15000);
            Employeinfo employe5 = new Employeinfo("Rakesh", 35000);

            int result = employe1.CompareTo(employe4);
            if (result == 1)
            {
                Console.WriteLine("Manthan has more salary than Rakesh");
            }
            else if (result == -1)
            {
                Console.WriteLine("Manthan has less salary than Rakesh");
            }
            else
            {
                Console.WriteLine("Manthan and Rakesh has same salary");
            }

        }
    }

}  




        

       
    


