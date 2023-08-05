# c-sharp-Hashtables-and-Dicitionary

Hashtables with c#

```c#
Create new Project
//Console App (.NET framework)
```

## Step 1 : Create Computers Class

```cs
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
```

## Step 2 : Create Your first hashtable
```cs
 using System.Collections;

 Hashtable ComputersTable = new Hashtable();
```

## Step 3 : Create Computers Objects then add them to the hashtable
```cs
 Computers cpt1 = new Computers(1, "HP Spectre", 1550);
 
 ComputersTable.Add(cpt1.Id, cpt1);
           
```

