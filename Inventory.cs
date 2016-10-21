using System;
using System.Collections.Generic;


namespace ConsoleApplication
{
    public class Inventory
    {
        //private property
        int maxItems=8;

        public int MaxItems
        {
            get {return maxItems;} //accesor (access private property)
            set {maxItems=value;} //mutator(changes value)
        }

        //Item is with capital letter because its public
        public List<Item> Items = new List<Item>();

        //public property IsOpen

        public bool IsOpen {get; set;}
       
        public Inventory()
        {

            
        }
   //class and instant of the object
        public void AddItem(Item item) 
        {
            if(IsOpen)
            {
                if(Items.Count<maxItems)
                {
            Items.Add(item);
                }
                else
                {
                    Console.WriteLine("Unable to add item, inventory is full");
                }
            }
            else
            {
                Console.WriteLine("Inventory is closed.");
            }
        }

        public void Open()
        {
            IsOpen=true;
            Console.WriteLine("Inventory is open");
        }

        public void Close()
        {
            IsOpen=false;
            Console.WriteLine("Inventory is close");
        }

        public void ListInventory()
        {
            //class,object,list
            foreach(Item item in Items)
            {
                item.Describe();
            }
        }
    }

}