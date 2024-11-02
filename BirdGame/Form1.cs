namespace BirdGame
{

    // ----- Babam Saðolsun ----- //

    public partial class Form1 : Form
    {
        // Vertical Movement speed
        int verticalMove = 8;
        // Horizontal Movement Speed
        int horizontalMove = -12;
        // Cloud Movement Speed
        int cloudSpeed = -10;
        // Score
        int score = 0;



        public Form1()
        {
            InitializeComponent();
            timer.Stop();
        }

        // When pressed 'Start' button
        private void start_Click(object sender, EventArgs e)
        {
            // Create necessary things
            PipeCreate();
            Retry();

            // Show hidden objects
            bird.Show();
            pipedown.Show();
            pipeup.Show();
            scoreLabel.Text = "Score: " + score;
            scoreLabel.Show();

            // Start timer
            timer.Start();

            // Hide start button
            start.Hide();
            this.Focus();
        }
        // When pressed down the 'Space' button vertical speed becames negative
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                verticalMove = -8;
            }
        }
        // When stopped pressing 'Space' button vertical speed reverts back
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                verticalMove = 8;
            }
        }
        // Timer 1 tick = 7 ms
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            bird.Top += verticalMove;
            pipeup.Left += horizontalMove;
            pipedown.Left += horizontalMove;
            cloud.Left += cloudSpeed;

            // When pipes touches the edge of the screen a new ones will be created
            if (pipeup.Right <= 0)
            {
                PipeCreate();
                score++;
                scoreLabel.Text = "Score: " + score;
            }

            // When cloud touches the edge of the screen a new one will be created
            if (cloud.Right <= 0)
            {
                CloudCreate();
            }

            // When score is above 5 horizontal speed will be increased
            if (score >= 5)
            {
                horizontalMove = -15;
            }

            // If Bird touches pipes or edges, game will be over
            if (bird.Bounds.IntersectsWith(pipeup.Bounds) || bird.Bounds.IntersectsWith(pipedown.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top <= -10)
            {
                timer.Stop();
                endLabel.Visible = true;
                start.Text = "Try Again";
                start.Visible = true;
                start.Focus();

            }

        }
        // Pipe creation
        public void PipeCreate()
        {
            Random Random = new Random();
            int gap = (10 * Random.Next(15, 21));
            int pipeupx = -(10 * Random.Next(0, 31));
            int pipedownx = (400 + pipeupx + gap);


            pipedown.Location = new Point(1300, pipeupx);
            pipeup.Location = new Point(1300, pipedownx);
        }
        // Cloud creation
        public void CloudCreate()
        {
            Random Random = new Random();
            int height = (10 * Random.Next(5, 36));
            cloud.Location = new Point(1300, height);
        }
        // Resetting necessary variables 
        public void Retry()
        {
            verticalMove = 8;
            horizontalMove = -12;
            score = 0;
            endLabel.Hide();
            bird.Location = new Point(300, 300);
        }
    }
}
