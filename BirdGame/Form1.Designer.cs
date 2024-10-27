using System.Timers;

namespace BirdGame
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
            ground = new PictureBox();
            bird = new PictureBox();
            start = new Button();
            timer = new System.Windows.Forms.Timer(components);
            pipeup = new PictureBox();
            pipedown = new PictureBox();
            endLabel = new Label();
            scoreLabel = new Label();
            cloud = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ground.Image = Properties.Resources.Grass;
            ground.Location = new Point(0, 611);
            ground.Name = "ground";
            ground.Size = new Size(1280, 70);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(200, 300);
            bird.Name = "bird";
            bird.Size = new Size(52, 46);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 1;
            bird.TabStop = false;
            bird.Visible = false;
            // 
            // start
            // 
            start.AutoSize = true;
            start.BackColor = Color.FromArgb(255, 128, 128);
            start.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            start.Location = new Point(544, 275);
            start.Name = "start";
            start.Size = new Size(150, 71);
            start.TabIndex = 2;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 7;
            timer.Tick += TimerEventProcessor;
            // 
            // pipeup
            // 
            pipeup.Anchor = AnchorStyles.None;
            pipeup.BackColor = Color.Transparent;
            pipeup.Image = Properties.Resources.pipe;
            pipeup.Location = new Point(800, 300);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(90, 400);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 3;
            pipeup.TabStop = false;
            pipeup.Visible = false;
            // 
            // pipedown
            // 
            pipedown.BackgroundImageLayout = ImageLayout.None;
            pipedown.Image = Properties.Resources.pipedown;
            pipedown.Location = new Point(800, -250);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(90, 400);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 4;
            pipedown.TabStop = false;
            pipedown.Visible = false;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            endLabel.Location = new Point(544, 224);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(138, 28);
            endLabel.TabIndex = 5;
            endLabel.Text = "Game Over";
            endLabel.Visible = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            scoreLabel.Location = new Point(50, 30);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(110, 28);
            scoreLabel.TabIndex = 6;
            scoreLabel.Text = "Score: ";
            // 
            // cloud
            // 
            cloud.Image = Properties.Resources.clouds;
            cloud.Location = new Point(200, 100);
            cloud.Name = "cloud";
            cloud.Size = new Size(300, 170);
            cloud.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud.TabIndex = 7;
            cloud.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1262, 673);
            Controls.Add(bird);
            Controls.Add(endLabel);
            Controls.Add(pipedown);
            Controls.Add(ground);
            Controls.Add(pipeup);
            Controls.Add(start);
            Controls.Add(scoreLabel);
            Controls.Add(cloud);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bird Game";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox ground;
        private PictureBox bird;
        private Button start;
        private System.Windows.Forms.Timer timer;
        private PictureBox pipeup;
        private PictureBox pipedown;
        private Label endLabel;
        private Label scoreLabel;
        private PictureBox cloud;
    }
}
