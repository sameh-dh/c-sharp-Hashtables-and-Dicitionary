using System;
//To use Dictionary : Dictionary are generic collection
using System.Collections.Generic;
//to use Hashtables : Hashtables are not a generic collection
using System.Collections;
using System.Linq;

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
            Computers cpt2 = new Computers(2, "Microsoft Surface", 1100);
            Computers cpt3 = new Computers(3, "Asus ROG Zephyrus G14", 1200);
            Computers cpt4 = new Computers(4, "MSI Prestige", 1400);
            Computers cpt5 = new Computers(5, "MacBook Pro", 2000);

            //Let's add the computers to the hashtable
            ComputersTable.Add(cpt1.Id, cpt1);
            ComputersTable.Add(cpt2.Id, cpt2);
            ComputersTable.Add(cpt3.Id, cpt3);
            ComputersTable.Add(cpt4.Id, cpt4);
            ComputersTable.Add(cpt5.Id, cpt5);


            /* Step : 4
             -------------------
              Let's retreive Data using hashtables
            */

            //4.1 Let's retreive one item with known id from the hashtable

            Computers Storedcpt2 = (Computers)ComputersTable[cpt2.Id];//cast the object with type Computers

            //4.2 okay now try to console.write it
            Console.WriteLine(Storedcpt2.Name);

            //4.3 Let's retrive all values from the computers hashtable
            //In order to do that we will use a DictionaryEntry,
            //so whenever we add new value to our hashtable
            //a new object will be created inside of our Dictionary
            foreach (DictionaryEntry entry in ComputersTable)
            {
                Computers value = (Computers)(entry.Value); //cast the value into type student
                Console.WriteLine(value.Name);
                Console.WriteLine(value.Price);

            }

            //4.4 another way with less code

            foreach (Computers value in ComputersTable.Values)
            {
                Console.WriteLine(value.Name);
                Console.WriteLine(value.Price);
            }

            /* Step : 5
          -------------------
           Good job now let's Discover Dictionaries
         */
            //To define Dicitionary we write : Dictionary<Tkey Tvalue>
            //5.1 Let's create new Computer array
            Computers[] copts =
            {
               new Computers(1, "HP Spectre", 1550),
               new Computers(2, "Microsoft Surface", 1100),
               new Computers(3, "Asus ROG Zephyrus G14", 1200),
               new Computers(4, "MSI Prestige", 1400),
               new Computers(5, "MacBook Pro", 2000),
             };
            //5.2 Let's create the Dicitionary 
            Dictionary<string, Computers> ComputersDic = new Dictionary<string, Computers>();
            /* Step : 6
             -------------------
         Let's fill the Dictionary
          */
            foreach (Computers value in copts)
            {
                ComputersDic.Add(value.Name, value);
            }
            /* Step : 7
            -------------------
        Let's get Data using Dictioanry
         */
            //7.1 Let's get one value using the name
            //note : you can use .ContainsKey("Hp spectre") to check if key exists
            Computers cptDic1 = ComputersDic["HP Spectre"];
            Console.WriteLine("getting Hp Spectre from Dictionary");
            Console.WriteLine(cptDic1.Price);
            //7.2 Let's get all data usning ElementAt() to return the key-value pair stored at the index
            for (int i =0; i<ComputersDic.Count;i++)
            {
                KeyValuePair<string, Computers> KeyValuePair = ComputersDic.ElementAt(i);
                //get the key
                string ComptKey = KeyValuePair.Key;
                //get value 
                Computers comptValue = KeyValuePair.Value;
                //Let's print the data 
                Console.WriteLine(comptValue.Name);
                Console.WriteLine(comptValue.Price);
            }

            /* Step : 8
             -------------------
             Let's update a value
            */
            // to update value : DictionaryName[key] = new object 

            ComputersDic["HP Spectre"] = new Computers(1, "Hp Spectre 360", 2000);
            //let's get the element and check the update 
            Console.WriteLine("update key");
            KeyValuePair<string, Computers> firstElement= ComputersDic.ElementAt(0);
            Console.WriteLine(firstElement.Key);
            Console.WriteLine(firstElement.Value.Name);

            /* Step : 8
             -------------------
             Let's remove a value
            */
            // to Remove value : DictionaryName.Remove[key] 
            ComputersDic.Remove("HP Spectre");
            //let's get the element and check the Remove
            Console.WriteLine("Remove key");
            KeyValuePair<string, Computers> newfirstElement = ComputersDic.ElementAt(0);
            Console.WriteLine(newfirstElement.Key);
            Console.WriteLine(newfirstElement.Value.Name);
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
