using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class GerericListp
    {
        public class Stud
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Fees { get; set; }
            public List<Stud> Studlist = new List<Stud>();
        }
        public class Program
        {

            static void Main(string[] args)
            {
                //coures   C#, MVC, JAVA, Angular, React...(id, name, fees)
                // enrolled students in course  (sid,name,city)
                List<Course> list = new List<Course>()
            {   
                new Course{
                    Id=1,
                    Name="C#",
                    Fees=89900,
                    Studlist={
                        new Stud{Id=101,City="Pune",Name="Stud1" },
                        new Stud{Id=102,City="Pune",Name="Stud2" }
                            }
                     },
                new Course{
                    Id=2,
                    Name="MVC",
                    Fees=89900,
                    Studlist={
                        new Stud{Id=103,City="Pune",Name="Stud3" },
                        new Stud{Id=104,City="Pune",Name="Stud4" },
                        new Stud{Id=105,City="Pune",Name="Stud5" },
                            }
                     },
                };


                foreach (Course c in list)
                {
                    Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                    foreach (Stud s in c.Studlist)
                    {
                        Console.WriteLine($"\t{s.Id}  {s.Name} {s.City}");
                    }
                }

            }
        }
    }
}
       
