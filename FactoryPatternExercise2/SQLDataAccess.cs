using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product () { Name = "Xbox", Price = 350 },
           new Product () { Name = "Guitar", Price = 1000 },
            new Product () { Name = "Blender", Price = 50 },
             new Product () { Name = "Piano", Price = 10000 },
              new Product () { Name = "Washing Machine", Price = 550 },
               new Product () { Name = "Playstation 5", Price = 500 },
                new Product () { Name = "Trombone", Price = 350 },
                 new Product () { Name = "Cooking Pot", Price = 20 }
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQL Data Access.");
        }
    }
}

