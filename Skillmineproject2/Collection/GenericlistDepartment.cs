using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class GenericlistDepartment
    {

        public class Employeeee
        {
            public int empyid { get; set; }
            public string empyname { get; set; }
            public int salary { get; set; }
        }
        public class Department
        {
            public int departmentid { get; set; }
            public string departmentname { get; set; }

            public List<Employeeee> emplist = new List<Employeeee>();
        }

        

        static void Main(string[] args)
        {

            List<Department> dept = new List<Department>()

            {
                new Department
                {
                    departmentid = 101,
                    departmentname = "HR Department",
                    emplist = {
                                 new Employeeee{ empyid = 1001, empyname = "Shubham", salary = 40000 },
                                  new Employeeee{ empyid = 1002, empyname = "Sahil", salary = 45000 },
                                  new Employeeee{ empyid = 1003, empyname = "Sanket", salary = 50000 }
                               }
                },







                new Department
                {
                    departmentid = 201,
                    departmentname = " Devlopement Department",
                    emplist = {
                    new Employeeee { empyid = 2001, empyname = "Manthan", salary = 12000 },
                    new Employeeee { empyid = 2001, empyname = "Manish", salary = 12000 },
                    new Employeeee { empyid = 2001, empyname = "Manoj", salary = 12000 },




                }
                },




            new Department
            {
                departmentid = 301,
                departmentname = "Testing Department",
                emplist = {
                    new Employeeee { empyid = 3001, empyname = "Abhinav", salary = 12000 },
                    new Employeeee { empyid = 3001, empyname = "Anup", salary = 12000 },
                    new Employeeee { empyid = 3001, empyname = "Aniket", salary = 12000 },




                }
                },

            };
            foreach(Department d in dept)
            {
                Console.WriteLine($"Department Id->  {d.departmentid} ,Department Name-> {d.departmentname}");
                foreach(Employeeee e in d.emplist)
                {
                    Console.WriteLine($"\tEmploye Id->{e.empyid}, Employe Name->{e.empyname}, Employe Salary-> {e.salary}");
                }
            }


        }
    }
}
