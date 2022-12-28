using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class CategoryandProductDetailsList
    {
        public class ProductD
        {
            public int Id { get; set; }
            public string PName { get; set; }
            public string Color { get; set; }
            public int Price { get; set; }

        }
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public List<ProductD> pdlist = new List<ProductD>();
        }
        static void Main(string[] args)
        {
            List<Category> list = new List<Category>()
            {
                new Category{Id=321,
                              Name="Furniture",
                    pdlist =
                    {
                        new ProductD{Id=1,PName="Chair",Color="Brown",Price=1000},
                        new ProductD{Id=2,PName="Sofa",Color="Black",Price=2000},
                        new ProductD{Id=3,PName="Daining table",Color="blue",Price=4500}
                    }
                },
                 new Category{Id =456,
                               Name="Mobile",
                     pdlist =
                     {
                         new ProductD{Id=1,PName="Samsung",Color="Black",Price=17000},
                         new ProductD{Id=2,PName="Nokia",Color="Green",Price=20000},
                         new ProductD{Id=3,PName="ONE+",Color="Red",Price=50000}
                     }
                 },
                 new Category{Id =456,
                               Name="Mens shirt",
                     pdlist =
                     {
                         new ProductD{Id=1,PName="WhiteButter",Color="White",Price=3000},
                         new ProductD{Id=2,PName="Orchid",Color="Green",Price=20000},
                         new ProductD{Id=3,PName="Pitter England+",Color="Red",Price=50000}
                     }
                 },

            };

           foreach(Category c in list)
            {
                Console.WriteLine($"Category Id->{c.Id}, Category Name-> {c.Name}");
                
                foreach(ProductD p in c.pdlist)
                {
                    Console.WriteLine($"\tProduct id->{p.Id}, Product Name-> {p.PName}, Product Color-> {p.Color}, Product Price-> {p.Price} ");
                }
                
            }
        }
    }
}
