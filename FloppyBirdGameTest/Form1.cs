using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloppyBirdGameTest
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 4;
        int gravity =  -15 ;
        int score = 0;


        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over " + score ;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Timer(200);
            //  bird.Top = bird.Top + gravity; metoda e zgjatur 
            bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;


            scoreText.Text = "Score: " + score;
            if (pipeDown.Left < -45)
            {
                pipeDown.Left = 400;
                score++;

            }
            if (pipeUp.Left < -45)
            {
                pipeUp.Left = 400;
                //score = score + 1 
                score++;

            }

            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)
            {
                endGame();

            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 30)
            {
                pipeSpeed= 30;
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void pipeUp1_Click(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
