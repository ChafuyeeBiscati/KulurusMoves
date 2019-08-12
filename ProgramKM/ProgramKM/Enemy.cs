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
        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = 10;
            y = spacing;
            width = 40;
            height = 40;
            enemyImage = Image.FromFile("seagull.png");
            enemyImage2 = Image.FromFile("monkey.png");
            enemyImage3 = Image.FromFile("rat.png");
            enemyImage4 = Image.FromFile("yeti.png");
            enemyRec = new Rectangle(x, y, width, height);
        }
        public void drawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }
        public void moveEnemy()
        {
            enemyRec.Location = new Point(x, y);
            if (enemyRec.Location.X > 650)
            {
                x = 20;
                enemyRec.Location = new Point(x, y);
                score += 1;// add 1 to score when planet reaches bottom of panel
            }

        }

    }
    }
