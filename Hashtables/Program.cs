using System;
//To use Dictionary : Dictionary are generic collection
using System.Collections.Generic;
//to use Hashtables : Hashtables are not a generic collection
using System.Collections;


namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Step : 2
             -------------------
              Let's create a Hashtable
            */
            Hashtable ComputersTable = new Hashtable();

            /* Step : 3
             -------------------
              Let's create some computers and add them to the hashtable
            */
            Computers cpt1 = new Computers(1, "HP Spectre", 1550);
            Computers cpt2 = new Computers(1, "Microsoft Surface", 1100);
            Computers cpt3 = new Computers(1, "Asus ROG Zephyrus G14", 1200);
            Computers cpt4 = new Computers(1, "MSI Prestige", 1400);
            Computers cpt5 = new Computers(1, "MacBook Pro", 2000);
           
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
