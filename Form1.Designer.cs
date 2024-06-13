namespace CarGame
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
            panel1 = new Panel();
            BestScore = new Label();
            Score = new Label();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            player = new PictureBox();
            roadTruck1 = new PictureBox();
            roadTruck2 = new PictureBox();
            Start = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTruck1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTruck2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(BestScore);
            panel1.Controls.Add(Score);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(player);
            panel1.Controls.Add(roadTruck1);
            panel1.Controls.Add(roadTruck2);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 777);
            panel1.TabIndex = 0;
            // 
            // BestScore
            // 
            BestScore.AutoSize = true;
            BestScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BestScore.ForeColor = Color.White;
            BestScore.Location = new Point(342, 4);
            BestScore.Name = "BestScore";
            BestScore.Size = new Size(167, 38);
            BestScore.TabIndex = 6;
            BestScore.Text = "BestScore: 0";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Score.ForeColor = Color.White;
            Score.Location = new Point(26, 0);
            Score.Name = "Score";
            Score.Size = new Size(115, 38);
            Score.TabIndex = 5;
            Score.Text = "Score: 0";
            // 
            // AI2
            // 
            AI2.Image = Properties.Resources.carGreen;
            AI2.Location = new Point(441, 272);
            AI2.Margin = new Padding(3, 4, 3, 4);
            AI2.Name = "AI2";
            AI2.Size = new Size(50, 101);
            AI2.SizeMode = PictureBoxSizeMode.AutoSize;
            AI2.TabIndex = 4;
            AI2.TabStop = false;
            AI2.Tag = "AI2";
            AI2.Visible = false;
            // 
            // AI1
            // 
            AI1.Image = Properties.Resources.ambulance;
            AI1.Location = new Point(78, 357);
            AI1.Margin = new Padding(3, 4, 3, 4);
            AI1.Name = "AI1";
            AI1.Size = new Size(50, 100);
            AI1.SizeMode = PictureBoxSizeMode.AutoSize;
            AI1.TabIndex = 3;
            AI1.TabStop = false;
            AI1.Tag = "AI1";
            AI1.Visible = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.carYellow;
            player.Location = new Point(277, 539);
            player.Margin = new Padding(3, 4, 3, 4);
            player.Name = "player";
            player.Size = new Size(50, 99);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 2;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // roadTruck1
            // 
            roadTruck1.Image = Properties.Resources.roadTrack;
            roadTruck1.Location = new Point(0, -773);
            roadTruck1.Margin = new Padding(3, 4, 3, 4);
            roadTruck1.Name = "roadTruck1";
            roadTruck1.Size = new Size(574, 779);
            roadTruck1.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTruck1.TabIndex = 0;
            roadTruck1.TabStop = false;
            // 
            // roadTruck2
            // 
            roadTruck2.Image = Properties.Resources.roadTrack;
            roadTruck2.Location = new Point(0, 4);
            roadTruck2.Margin = new Padding(3, 4, 3, 4);
            roadTruck2.Name = "roadTruck2";
            roadTruck2.Size = new Size(574, 779);
            roadTruck2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTruck2.TabIndex = 1;
            roadTruck2.TabStop = false;
            // 
            // Start
            // 
            Start.Location = new Point(253, 790);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(86, 31);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 10;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 832);
            Controls.Add(Start);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Car Racing";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTruck1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTruck2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox roadTruck2;
        private PictureBox roadTruck1;
        private Button Start;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox AI2;
        private PictureBox AI1;
        private Label BestScore;
        private Label Score;
    }
}