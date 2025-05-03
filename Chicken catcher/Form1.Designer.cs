namespace Chicken_catcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            egg1 = new PictureBox();
            egg2 = new PictureBox();
            egg3 = new PictureBox();
            txtScore = new Label();
            txtMissing = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg3).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources._26350120_xl9v_1uig_220408;
            player.Location = new Point(409, 485);
            player.Name = "player";
            player.Size = new Size(103, 114);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += pictureBox1_Click;
            // 
            // egg1
            // 
            egg1.Image = Properties.Resources._28768528_6qza_mwwx_220517;
            egg1.Location = new Point(304, 51);
            egg1.Name = "egg1";
            egg1.Size = new Size(54, 55);
            egg1.SizeMode = PictureBoxSizeMode.StretchImage;
            egg1.TabIndex = 1;
            egg1.TabStop = false;
            egg1.Tag = "eggs";
            egg1.Click += egg1_Click;
            // 
            // egg2
            // 
            egg2.Image = Properties.Resources._28768528_6qza_mwwx_2205171;
            egg2.Location = new Point(474, 51);
            egg2.Name = "egg2";
            egg2.Size = new Size(55, 55);
            egg2.SizeMode = PictureBoxSizeMode.StretchImage;
            egg2.TabIndex = 2;
            egg2.TabStop = false;
            egg2.Tag = "eggs";
            egg2.Click += egg2_Click;
            // 
            // egg3
            // 
            egg3.Image = Properties.Resources._28768528_6qza_mwwx_2205172;
            egg3.Location = new Point(658, 51);
            egg3.Name = "egg3";
            egg3.Size = new Size(53, 55);
            egg3.SizeMode = PictureBoxSizeMode.StretchImage;
            egg3.TabIndex = 3;
            egg3.TabStop = false;
            egg3.Tag = "eggs";
            egg3.Click += egg3_Click;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.ForestGreen;
            txtScore.Location = new Point(12, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(174, 40);
            txtScore.TabIndex = 4;
            txtScore.Text = "Score: 10";
            txtScore.Click += points_Click;
            // 
            // txtMissing
            // 
            txtMissing.AutoSize = true;
            txtMissing.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMissing.ForeColor = Color.Maroon;
            txtMissing.Location = new Point(814, 9);
            txtMissing.Name = "txtMissing";
            txtMissing.Size = new Size(205, 40);
            txtMissing.TabIndex = 5;
            txtMissing.Text = "missing: 10";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 660);
            Controls.Add(txtMissing);
            Controls.Add(txtScore);
            Controls.Add(egg3);
            Controls.Add(egg2);
            Controls.Add(egg1);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += KeyIsDowm;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox egg1;
        private PictureBox egg2;
        private PictureBox egg3;
        private Label txtScore;
        private Label txtMissing;
        private System.Windows.Forms.Timer GameTimer;
    }
}
