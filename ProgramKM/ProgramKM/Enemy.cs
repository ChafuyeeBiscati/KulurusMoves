using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ProgramKM
{
    class Enemy
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage, enemyImage2, enemyImage3, enemyImage4;//variable for the planet's image
        public Rectangle enemyRec;//variable for a rectangle to place our image in
        public int score;
        public int level = 3;
        public bool one, two, three, four;
        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = 10;
            y = spacing;
            width = 40;
            height = 40;
            enemyImage = Image.FromFile("seagull.png");
            enemyImage2 = Image.FromFile("Monkey.png");
            enemyImage3 = Image.FromFile("slime.jpg");
            enemyImage4 = Image.FromFile("yeti.gif");
            enemyRec = new Rectangle(x, y, width, height);

        }
        public void drawEnemy(Graphics g)
        {
           if (one == true)
            {
                g.DrawImage(enemyImage, enemyRec);
              
            }
            if (two == true)
            {
                g.DrawImage(enemyImage2, enemyRec);
                
            }
            if (three == true)
            {
                g.DrawImage(enemyImage3, enemyRec);
               
            }
            if (four == true)
            {
                g.DrawImage(enemyImage4, enemyRec);
             
            }
            enemyRec = new Rectangle(x, y, width, height);
        }
        public void moveEnemy()
        {
            enemyRec.Location = new Point(x, y);
            if (enemyRec.Location.X > 675)
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                x = 0;
                enemyRec.Location = new Point(x, y);
            }

        }

    }
    }
