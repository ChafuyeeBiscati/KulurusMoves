using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace ProgramKM
{
    public partial class KMForm : Form
    {
        Graphics g; //declare a graphics object called g
        Enemy[] seagull = new Enemy[7];
        Random xspeed = new Random();
        Kuluru kuluru = new Kuluru();
        bool left, right;//Makes the use of the left and right boolean in the method code
        bool up, down;//Makes the use of the up and down boolean in the method code\
        int score, lives;
        string move;

        public KMForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, KMPanel1, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 50);
                seagull[i] = new Enemy(y);
            }

        }

        private void KMForm_Load(object sender, EventArgs e)
        {
            KMPanel1.Visible = false;
            KMPanel2.Visible = false;
            lives = int.Parse(TxtLives.Text);// pass lives entered from textbox to lives variable
            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            TxtName.Focus();

        }

        private void TxtLevel_Click(object sender, EventArgs e)
        {

        }

        private void KMPanel_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 15);
                seagull[i].x += rndmspeed;

                seagull[i].drawEnemy(g);
            }
            kuluru.drawKuluru(g); 
;

        }

        private void tmrKrool_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                kuluru.moveKuluru(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                kuluru.moveKuluru(move);
            }
            if (up) // if right arrow key pressed
            {
                move = "up";
                kuluru.moveKuluru(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                kuluru.moveKuluru(move);
            }

        }

        private void KMForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(TxtLives.Text);// pass lives entered from textbox to lives variable
            tmrEnemy.Enabled = true;
            tmrKrool.Enabled = true;

        }

        private void KMForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }

        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                seagull[i].moveEnemy();
                if (kuluru.kroolRec.IntersectsWith(seagull[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    seagull[i].x = 20; // set  y value of planetRec
                    lives -= 1;// lose a life
                    TxtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }


                score += seagull[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score

            }
            KMPanel1.Invalidate();//makes the paint event fire to redraw the panel

        }
        private void checkLives()
        {
            if (lives == 0)
            {
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }


    }
}
