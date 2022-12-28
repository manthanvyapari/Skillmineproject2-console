using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class BooklibraryList
    {
        public class BookLibrary
        {
            public int lineno{ get; set; }
            public int shellno { get; set; }

            public List<Categiries> catelist = new List<Categiries>();
        }
        public class Categiries
        {
            public int subshell { get; set; }
            public string booktype { get; set; }
            public string bookname { get; set; }
            public string author { get; set; }
            public int price { get; set; }
        }

        
        static void Main(string[] args)
        {
            List<BookLibrary> list = new List<BookLibrary>()
            {
                new BookLibrary{lineno=1,
                                shellno=4,
                    catelist =
                    {
                        new Categiries{subshell=1,booktype="comic",bookname="abc",author="xyz",price=1000},
                        new Categiries{subshell=2,booktype="Marvel comic",bookname="Avenger",author="Stan lee",price=12000},
                        new Categiries{subshell=3,booktype="DC comic",bookname="Batman",author="malcolm wheeler",price=3200},
                    }

                },



                 new BookLibrary{lineno=2,
                                shellno=6,
                    catelist =
                    {
                        new Categiries{subshell=3,booktype="Historic book",bookname="Chatrapti Shivaji Maharaj",author="maratha",price=1000},
                        new Categiries{subshell=4,booktype="historic Book",bookname="Padmavat",author="malik mohd jayasi",price=12000},
                        new Categiries{subshell=5,booktype="historic Bokk",bookname="charak samhita",author="charaka",price=3200},
                    }

                },

            };
            
            foreach(BookLibrary  b in list)
            {
                Console.WriteLine($"{b.lineno} {b.shellno}");
                foreach(Categiries c in b.catelist)
                {
                    Console.WriteLine($"\t{c.subshell}");
                }

                
            }










                 
        }
    }
}
