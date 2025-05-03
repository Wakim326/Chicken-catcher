namespace Chicken_catcher


{
    public partial class Form1 : Form
    {
        bool goLeft, goRight;

        int speed = 10;
        int score = 0;
        int missed = 0;

        Random randx = new Random();
        Random randy = new Random();

        PictureBox splash = new PictureBox();

        

        public Form1()
        {
            InitializeComponent();
            RestartGame();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void egg1_Click(object sender, EventArgs e)
        {

        }

        private void egg2_Click(object sender, EventArgs e)
        {

        }

        private void egg3_Click(object sender, EventArgs e)
        {

        }

        private void points_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Saved: " + score;
            txtMissing.Text = "Missed:  " + missed;

            if (goLeft == true && player.Left > 0)
            {
                player.Left = 12;
                player.Image = Properties.Resources.chicken_normal2;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.chicken_normal;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {



                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = randy.Next(80, 300) * -1;
                        x.Left = randy.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        player.Image = Properties.Resources.chicken_hurts;

                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randy.Next(80, 300) * -1;
                        x.Left = randy.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                    }
                }
            }
            if (score > 10)
            {
                speed = 12;
            }
            if (missed > 5)
            {
                GameTimer.Stop();
                MessageBox.Show("Game Over!" + Environment.NewLine + "We,ve lost good Eggs! " + Environment.NewLine + "Click ok to retry");
                RestartGame();
            }
        }

        private void KeyIsDowm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right) 
            { 
                goRight = true; 
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }


        private void RestartGame()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "egg")
                {
                    x.Top = randy.Next(80, 300) * -1;
                    x.Left = randy.Next(5,this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.chicken_normal;

            score = 0;
            speed = 0;
            missed = 0; 

            goLeft = false;
            goRight = false;

            GameTimer.Start();
        }
    }
}
