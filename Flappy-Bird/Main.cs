using System;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PipeBottom.Left -= Game.pipeSpeed;
            PipeTop.Left -= Game.pipeSpeed;
            BirdPb.Top += Game.gravity;

            if (BirdPb.Bounds.IntersectsWith(Ground.Bounds) || BirdPb.Bounds.IntersectsWith(PipeTop.Bounds) 
                || BirdPb.Bounds.IntersectsWith(PipeBottom.Bounds) || BirdPb.Bounds.IntersectsWith(Top.Bounds))
            {
                GameOver();
            }
            if (PipeBottom.Left < -80)
            {
                PipeBottom.Left = 1000;
                User.score += 1;
            }
            else if (PipeTop.Left < -95)
            {
                PipeTop.Left = 1100;
                User.score += 1;
            }
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Game.isPlaying)
            {
                GameDelay.Start();
                BirdPb.Visible = true;
                Game.isPlaying = true;
                SpaceLabel.Text = "Get Ready!";
            }

            if (e.KeyCode == Keys.Space && Game.isPlaying)
            {
                Game.isJumping = true;
                Game.gravity = -5;
            }
        }
        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && Game.isPlaying)
            {
                Game.isJumping = false;
                Game.gravity = 5;
            }
        }
        private void GameOver()
        {
            GameTimer.Stop();
            SpaceLabel.Visible = true;
            SpaceLabel.Text = "Score: " + User.score + "\nPress Space To Start";
            Restart();
        }
        private void Restart()
        {
            Game.isPlaying = false;
            User.score = 0;
            Game.delayInterval = 300;
            Game.isJumping = false;
            Game.gravity = 5;
            BirdPb.Location = new System.Drawing.Point(108, 145);
        }
        private void GameDelay_Tick(object sender, EventArgs e)
        {
            switch (Game.delayInterval)
            {
                case 0:
                    GameDelay.Stop();
                    SpaceLabel.Visible = false;
                    break;
                case 50:
                    PipeTop.Visible = true;
                    PipeBottom.Visible = true;
                    GameTimer.Start();
                    break;
                case 100:
                    SpaceLabel.Text = "GO!";
                    break;
                case 200:
                    SpaceLabel.Text = "Get Set!";
                    break; 
            }
            Game.delayInterval--;
        }
    }
}
