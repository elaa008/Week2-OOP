using System;
using System.Threading;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
           Player player1 = new Player(); 
           
           
            Console.WriteLine("Hello Elina!");
            Console.ReadLine();
            Console.Clear();

     

            while(true)
            {
                if(Console.KeyAvailable)
                {
                string direction="";
                ConsoleKeyInfo keyPress= Console.ReadKey(true);
                if (keyPress.Key==ConsoleKey.UpArrow)
                {
                    direction="up";
                }

                if (keyPress.Key==ConsoleKey.DownArrow)
                {
                    direction="down";
                }

                if (keyPress.Key==ConsoleKey.LeftArrow)
                {
                    direction="left";
                }

                if (keyPress.Key==ConsoleKey.RightArrow)
                {
                    direction="right";
                }
                
                player1.Move(direction);
                }

                Console.Clear();
                player1.Draw();
                Thread.Sleep(1000/30);
            }
                

            
    }
}
}
