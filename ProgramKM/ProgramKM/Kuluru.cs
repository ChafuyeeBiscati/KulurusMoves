using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgramKM
{
    class Kuluru
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image kuluru;//variable for the planet's image

        public Rectangle kroolRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Kuluru()
        {
            x = 600;
            y = 150;
            width = 50;
            height = 50;
            kuluru = Image.FromFile("lizard.png");
            kroolRec = new Rectangle(x, y, width, height);
        }
        public void drawKuluru(Graphics g)
        {
            g.DrawImage(kuluru, kroolRec);
        }
        public void moveKuluru(string move)
        {
            kroolRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (kroolRec.Location.X > 625) // is spaceship within 50 of right side
                {

                    x = 625;
                    kroolRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    kroolRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (kroolRec.Location.X < 0) // is spaceship within 10 of left side
                {
                    x = 0;
                    kroolRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    kroolRec.Location = new Point(x, y);
                }


                if (move == "up")
                {
                    if (kroolRec.Location.Y < 10) // is spaceship within 10 of left side
                    {
                        y = 10;
                        kroolRec.Location = new Point(x, y);
                    }
                    else
                    {
                        y -= 5;
                        kroolRec.Location = new Point(x, y);
                    }
                if (move == "down")
                    {
                        if (kroolRec.Location.Y > 325) // is spaceship within 10 of left side
                        {
                            y = 325;
                            kroolRec.Location = new Point(x, y);
                        }
                        else
                        {
                            y += 5;
                            kroolRec.Location = new Point(x, y);
                        }

                    }
                }
            }
            }
}
}
