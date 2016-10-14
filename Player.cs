using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Player
    {
        int xPosition;
        int yPosition;
        char sprite;
        int health;
        int speed;

//properties
        public int XPosition
        {
            get { return xPosition; }
            set { xPosition= value; }
        }
         public int YPosition
        {
            get { return yPosition; }
            set { yPosition= value; }
        }

//method
        public Player()
        {
            sprite='&';
            xPosition=3;
            yPosition=3;
            speed=1;
        }

//method
        public void Draw()
        {
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.Write(sprite);

        } 
//method
        public void Move(string direction)
        {
            switch(direction)
            {
                case "up":
                    yPosition-=speed;
                break;

                case "down":
                    yPosition+=speed;
                break;

                case "left":
                    xPosition-=speed;
                break;

                case "right":
                    xPosition+=speed;
                break;

                default:
                break;

            }
        }

    }
}