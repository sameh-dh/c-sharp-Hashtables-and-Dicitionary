# c-sharp-Hashtables-and-Dicitionary

Hashtables with c#

```c#
Create new Project
//Console App (.NET framework)
```

## Step 1: Create Computers Class

```c#
    /*
    Let's create a Computers class to use it in the hashtable
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
```
