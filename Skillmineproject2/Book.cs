using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    class Book
    {
       private  int id;
       private string name;
       private string author;
       private int price;
        
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Author
        {
            set
            {
                author = value;
            }
            get
            {
                return author;
            }
        }
        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }



    }


   // Book b = new Book();

   // b.Id = 254612;
      ///          b.Name = "XYZ";
      //          b.Author = "ABC";
       //         b.Price = 250;

        //        Console.WriteLine(b.Id + " " + b.Name + " " + b.Aut






}
