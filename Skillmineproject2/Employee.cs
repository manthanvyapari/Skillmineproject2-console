using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    public class Employee
    {
       protected  int empid;
        protected string empname;
        protected double basic, hra, da, pf, gross;
        protected static int count;

        public Employee(int empid, string empname, double basic)
        {
            count++;
            this.empid = count;
            this.empname = empname;
            this.basic = basic;
        }
        public virtual void  CalculateSallary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;

        }
        //ToString()--->string represent of an object

        public override string ToString()
        {
            return $"Employee id--->{empid},Employee name--->{empname},& gross sallary of emp--->{gross}";
        }

        public double GetGrossSallary()
        {
            return gross;
        }

    }

    public class Manager : Employee
    {
        private double food;
        public Manager(int id, string name, double bs, double food) : base(id, name, bs)
        {
            this.food = food;
        }
        public override void CalculateSallary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + food) - pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of manager {gross}";
        }
    }

    public class SalesManager : Employee
    {
        private int comm;
        private int bonus;

        public SalesManager(int id, string name, double bs, double food,int comm,int bonus) : base(id, name, bs)
        {
            this.comm = comm;
            this.bonus = bonus;
        }
        public override void CalculateSallary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + comm + bonus) - pf;
        }
        public override string ToString()
        {
            return $"Employee id {empid},emp name {empname}, gross salary of salsemaneger {gross}";
        }
    }

      
    //public new void CalculateSalary()
    //{
    //    hra = basic * 0.40;
    //    da = basic * 0.20;
    //    pf = basic * 0.12;
    //    gross = (basic + hra + da + food) - pf;
    //}





}


