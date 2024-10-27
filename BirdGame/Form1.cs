namespace BirdGame
{
    public partial class Form1 : Form
    {
        int verticalMove = 8;
        int horizontalMove = -12;
        int cloudSpeed = -10;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
            timer.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            PipeCreate();
            Retry();
            bird.Show();
            pipedown.Show();
            pipeup.Show();
            scoreLabel.Text = "Score: " + score;
            scoreLabel.Show();
            timer.Start();

            start.Hide();
            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                verticalMove = -8;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                verticalMove = 8;
            } 
        }
        private void TimerEventProcessor(Object myObject,EventArgs myEventArgs) 
        {
            bird.Top += verticalMove;
            pipeup.Left += horizontalMove;
            pipedown.Left += horizontalMove;
            cloud.Left += cloudSpeed;   

            if (pipeup.Right <= 0)
            {
                PipeCreate();
                score++;
                scoreLabel.Text = "Score: " + score;
            }

            if (cloud.Right <= 0)
            {
                CloudCreate();
            }

            if (score > 5)
            {
                horizontalMove = -15;
            }

            if (bird.Bounds.IntersectsWith(pipeup.Bounds) || bird.Bounds.IntersectsWith(pipedown.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top == -0)
            {
                timer.Stop();
                endLabel.Visible = true;
                start.Text = "Try Again";
                start.Visible = true;
                start.Focus();

            }
            
        }
        public void PipeCreate()
        {
            Random Random = new Random();
            int gap = (10 * Random.Next(15, 21));
            int pipeupx = -(10 * Random.Next(0, 31));
            int pipedownx = (400 + pipeupx + gap);


            pipedown.Location = new Point(1300, pipeupx);
            pipeup.Location = new Point(1300, pipedownx);
        }
        public void CloudCreate()
        {
            Random Random = new Random();
            int height = (10 * Random.Next(5, 36));   
            cloud.Location = new Point(1300,height);
        }
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
