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

        Console.Clear();       

            Console.Write("Player 1, press a key to represent your player: ");
           char playerSprite=Console.ReadKey().KeyChar;

          players.Add(new Player(playerSprite));

           
           //Console.Write("Player 2, press a key to represent your player: ");
          // playerSprite=Console.ReadKey().KeyChar;

           // players.Add(new Player(playerSprite, ConsoleColor.Magenta));
          
           
            Console.WriteLine("\n\nHello Jan!");
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
            
                if(keyPress.Key==ConsoleKey.Z)
                {
                    players[0].inventory.Open();
                    players[0].inventory.AddItem(new Item("Sword","A shiny sword", 't'));
                    players[0].inventory.Close();
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
                Console.SetCursorPosition(1,5);
                player.inventory.ListInventory(); 
            }
            Console.ForegroundColor=ConsoleColor.Green;
        }
    }
}
