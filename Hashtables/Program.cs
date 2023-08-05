using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    /* Step : 1 
    -------------------
    Let's create a Computers class to use it as an example in the hashtable
     */
    class Computers
    {
        //porperties 
        public int Id { get; set;  }
        public string Name { get; set; }
        public double Price { get; set; }
        //constructor
        public Computers(int id, string name, double price)
        {
           this.Id = id;
           this.Name = name;
           this.Price = price;
        }
    }

    
}
