# c-sharp-Hashtables-and-Dicitionary


```c#
Create new Project
//Console App (.NET framework)
```
# Hashtable
## Step 1 : Create Computers Class 😒

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

## Step 2 : Create Your first hashtable 😔

```cs
 using System.Collections;

 Hashtable ComputersTable = new Hashtable();
```

## Step 3 : Create Computers Objects then add them to the hashtable 😎

```cs
 Computers cpt1 = new Computers(1, "HP Spectre", 1550);
 Computers cpt2 = new Computers(2, "Microsoft Surface", 1100);
 ComputersTable.Add(cpt1.Id, cpt1);
 ComputersTable.Add(cpt2.Id, cpt2);

```

## Step 4 : Retreive Data using Hashtables 🥰

```cs
// One item :
 Computers Storedcpt2 = (Computers)ComputersTable[cpt2.Id];
// All items :
    foreach (Computers value in ComputersTable.Values)
            {
                Console.WriteLine(value.Name);
                Console.WriteLine(value.Price);
            }
```

# Dicitonary

## Step 1 : Create Dictionary 😒

```cs
   using System.Collections.Generic;
   //create  Computers array, we will use it to fill the Dictionary
     Computers[] copts =
            {
               new Computers(1, "HP Spectre", 1550),
               new Computers(2, "Microsoft Surface", 1100),
            }
    //Create Dictionary
     Dictionary<string, Computers> ComputersDic = new Dictionary<string, Computers>();
```

## Step 2 : Fill the Dictionary 😎

```cs
   foreach (Computers value in copts)
            {
                ComputersDic.Add(value.Name, value);
            }
```
## Step 3 : Retreive Data using Dictionary 🥰

```cs
// One item :
   Computers cptDic1 = ComputersDic["HP Spectre"];
// All items :
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

```

## Step 4 : update Data using Dictionary 🤗

```cs
// to update value : DictionaryName[key] = new object 
ComputersDic["HP Spectre"] = new Computers(1, "Hp Spectre 360", 2000);
//Note : using this method the key will be always the same only the value name will change

```

## Step 5 : Remove Data using Dictionary 😅

```cs
// to Remove value : DictionaryName.Remove[key] 
ComputersDic.Remove("HP Spectre");
```

### We are Done Have a nice day 🌸🌸🌸