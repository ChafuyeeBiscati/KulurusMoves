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
        Enemy[] enemy = new Enemy[7];
        Random xspeed = new Random();
        Kuluru kuluru = new Kuluru();
        bool left, right;//Makes the use of the left and right boolean in the method code
        bool up, down;//Makes the use of the up and down boolean in the method code\
        int score, lives;
        bool one;
        bool two;
        bool three;
        bool four;
        int level = 1;
        string move;

        public KMForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, KMPanel1, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 50);
                enemy[i] = new Enemy(y);
            }

        }

        private void KMForm_Load(object sender, EventArgs e)
        {
            one = false;
            two = false;
            three = false;
            four = false;
            KMPanel1.Visible = false;
            TxtName.Focus();
            tmrEnemy.Enabled = false;
            tmrKrool.Enabled = false;

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
                enemy[i].x += rndmspeed;

                enemy[i].drawEnemy(g);
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


        }

        private void KMLevel1_Click(object sender, EventArgs e)
        {
            lives = int.Parse(LivesTxt.Text);// pass lives entered from textbox to lives variable
            if (lives <= 0)
            {
                KMPanel1.Visible = false;
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Please Enter A Valide Life Integer");
            }
            if (lives > 0)
            {
                level = 1;
                TxtLevel.Text = level.ToString();
                score = 0;
                lblScore.Text = score.ToString();
                KMPanel1.Visible = true;
                KMPanel1.BackgroundImage = Image.FromFile("Ship_1.png");
                MessageBox.Show("Kuluru begins his journey on the ship of King Krool.\n To reach DK Island Kuluru must make it past the enslaught of seagulls.\n Your goal is to use the movement of Kuluru to dodge as many seagulls as you can.");
                tmrEnemy.Enabled = true;
                tmrKrool.Enabled = true;
            }
        }

        private void KMLevel2_Click(object sender, EventArgs e)
        {
            lives = int.Parse(LivesTxt.Text);// pass lives entered from textbox to lives variable
            if (lives <= 0)
            {
                KMPanel1.Visible = false;
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Please Enter A Valide Life Integer");
            }
            if (lives > 0)
            {
            level = 2;
            TxtLevel.Text = level.ToString();
            score = 0;
            lblScore.Text = score.ToString();
            KMPanel1.Visible = true;
            KMPanel1.BackgroundImage = Image.FromFile("Jungle_1.png");
            MessageBox.Show("");
            tmrEnemy.Enabled = true;
            tmrKrool.Enabled = true;
            }
        }

        private void KMLevel3_Click(object sender, EventArgs e)
        {
            lives = int.Parse(LivesTxt.Text);// pass lives entered from textbox to lives variable
            if (lives <= 0)
            {
                KMPanel1.Visible = false;
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Please Enter A Valide Life Integer");
            }
            if (lives > 0)
            {
            level = 3;
            TxtLevel.Text = level.ToString();
            score = 0;
            lblScore.Text = score.ToString();
            KMPanel1.Visible = true;
            KMPanel1.BackgroundImage = Image.FromFile("Cave_1.png");
            MessageBox.Show("");
            tmrEnemy.Enabled = true;
            tmrKrool.Enabled = true;
            }
        }

        private void KMLevel4_Click(object sender, EventArgs e)
        {
            lives = int.Parse(LivesTxt.Text);// pass lives entered from textbox to lives variable
            if (lives <= 0)
            {
                KMPanel1.Visible = false;
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Please Enter A Valide Life Integer");
            }
            if (lives > 0)
            {
            level = 4;
            TxtLevel.Text = level.ToString();
            score = 0;
            lblScore.Text = score.ToString();
            KMPanel1.Visible = true;
            KMPanel1.BackgroundImage = Image.FromFile("Mount_1.png");
            MessageBox.Show("");
            tmrEnemy.Enabled = true;
            tmrKrool.Enabled = true;
            }
        }

        private void KMPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtLives_Click(object sender, EventArgs e)
        {

        }

        private void Txtlives_TextChanged(object sender, EventArgs e)
        {

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
            score = 0;
            for (int i = 0; i < 7; i++)
            {
                enemy[i].moveEnemy();
                if (kuluru.kroolRec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].x = 20; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LivesTxt.Text = lives.ToString();// display number of lives
                    checkLives();
                }


                score += enemy[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score

            }
            KMPanel1.Invalidate();//makes the paint event fire to redraw the panel

        }
        private void checkLives()
        {
            if (lives == 0)
            {
                this.Close();
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }


    }
}
