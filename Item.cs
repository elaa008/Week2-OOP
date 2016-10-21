using System;

namespace ConsoleApplication
{
    public class Item
    //if the first letter is small then its private if its uppear then its public
    {
        string name;
        string description;
        char sprite;
       //method always has the same name as class
        public Item()
        {

        }

          public Item (string name, string description, char sprite)
          {   
            this.name=name;
            this.description=description;
            this.sprite=sprite;
          }

//methods always contain void to return result back 
          public void Draw()
          {
              Console.Write(sprite);
          }

          public void Describe()
          {
              Console.WriteLine(name+ ": " +description);
          }
    }
}