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
using System.Media;

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
        int level;
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player5 = new System.Media.SoundPlayer();
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
            //Disable the buttons for isletter
            KMLevel1.Enabled = false;
            KMLevel2.Enabled = false;
            KMLevel3.Enabled = false;
            KMLevel4.Enabled = false;
            KMLevel5.Enabled = false;
            KMLevel1.Visible = true;
            KMLevel2.Visible = true;
            KMLevel3.Visible = true;
            KMLevel4.Visible = true;
            KMLevel5.Visible = true;
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
                int rndmspeed = xspeed.Next(2, 15);
                enemy[i].x += rndmspeed;

                enemy[i].drawEnemy(g,level);
            }
            kuluru.drawKuluru(g); 


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
            if (up) // if up arrow key pressed
            {
                move = "up";
                kuluru.moveKuluru(move);
            }
            if (down) // if down arrow key pressed
            {
                move = "down";
                kuluru.moveKuluru(move);
            }

        }

       

        private void BtnStart_Click(object sender, EventArgs e)
        {


        }

        private void KMLevel1_Click(object sender, EventArgs e)
        {
            level = 1;
         
            //***** go to method to hide buttons and start game
            start_game(level);
           
        }
        private void start_game(int level)
        {
            player1.SoundLocation = "Music1.wav";
            player2.SoundLocation = "Music2.wav";
            player3.SoundLocation = "Music3.wav";
            player4.SoundLocation = "Music4.wav";
            player5.SoundLocation = "Music5.wav";
            KMLevel1.Visible = false;
            KMLevel2.Visible = false;
            KMLevel3.Visible = false;
            KMLevel4.Visible = false;
            KMLevel5.Visible = false;
            lives = int.Parse(LivesTxt.Text);// pass lives entered from textbox to lives variable
            TxtLevel.Text = level.ToString();
            score = 0;
            lblScore.Text = score.ToString();
            KMPanel1.Visible = true;
            if (level == 1)
            {
                player1.Play();
                KMPanel1.BackgroundImage = Image.FromFile("Ship_1.png");
                MessageBox.Show("Kuluru begins his journey on the ship of King Krool.\n To reach DK Island Kuluru must make it past the enslaught of seagulls.\n Your goal is to use the movement of Kuluru to dodge as many seagulls as you can.");
            }
            if (level == 2)
            {
                player2.Play();
                KMPanel1.BackgroundImage = Image.FromFile("Jungle_1.png");
                MessageBox.Show("Kuluru blah level2");
            }
            if (level == 3)
            {
                player3.Play();
                KMPanel1.BackgroundImage = Image.FromFile("Cave_1.png");
                MessageBox.Show("Kuluru blah level 3");
            }
            if (level == 4)
            {
                player4.Play();
                KMPanel1.BackgroundImage = Image.FromFile("Mount_1.png");
                MessageBox.Show("Kuluru blah level 4");
            }
            if (level == 5)
            {
                player5.Play();
                KMPanel1.BackgroundImage = Image.FromFile("Lava_1.png");
                MessageBox.Show("Kuluru blah level 5");
            }
            tmrEnemy.Enabled = true;
            tmrKrool.Enabled = true;
        }

        private void KMLevel2_Click(object sender, EventArgs e)
        { 

            level = 2;
            start_game(level);
          
        }

        private void KMLevel3_Click(object sender, EventArgs e)
        {
            level = 3;
            start_game(level);
        }

        private void KMLevel4_Click(object sender, EventArgs e)
        {
            level = 4;
            start_game(level);
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

        private void KMForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

        }

        private void KMLevel5_Click(object sender, EventArgs e)
        {
            level = 5;
            start_game(level);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }
            }
            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                KMLevel1.Enabled = true;
                KMLevel2.Enabled = true;
                KMLevel3.Enabled = true;
                KMLevel4.Enabled = true;
                KMLevel5.Enabled = true;
            }
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

               // KMPanel1.Invalidate();//makes the paint event fire to redraw the panel
                score += enemy[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score

            }
            KMPanel1.Invalidate();//makes the paint event fire to redraw the panel

        }
        private void checkLives()
        {
            if (lives <= 0)
            {
                player1.Stop();
                player2.Stop();
                player3.Stop();
                player4.Stop();
                player5.Stop();
                KMLevel1.Visible = true;
                KMLevel2.Visible = true;
                KMLevel3.Visible = true;
                KMLevel4.Visible = true;
                KMLevel5.Visible = true;
                KMPanel1.Visible = false;
                //this.Close();
                tmrEnemy.Enabled = false;
                tmrKrool.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }


    }
}
