using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
           List<Player> players=new List<Player>();

           players.Add(new Player());
            players.Add(new Player());
          
           
            Console.WriteLine("Hello Elina!");
            Console.WriteLine("Press any key to begin!");
            Console.ReadLine();

//foreach for players

            Draw(players);
           // foreach (Player player in players)
          //  {
           //     player.Draw();
          //  }
           // Console.Clear();
            //players[0].Draw();
            //players[1].Draw();

     

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
                
                players[0].Move(direction);
                }

                Console.Clear();

                Draw(players);
             //     foreach (Player player in players)
           // {
          //      player.Draw();
          //  }
               // player1.Draw();
                Thread.Sleep(1000/30);
            }
                

            
    }
    public static void Draw(List<Player>players)
        {
          foreach (Player player in players)
            {
                player.Draw();
            }
        }
    }
}
