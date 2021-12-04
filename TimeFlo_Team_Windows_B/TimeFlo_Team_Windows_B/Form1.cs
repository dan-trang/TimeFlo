namespace TimeFlo_Team_Windows_B
{
    public partial class Form1 : Form
    {
        private int totalSecondsWork;
        private int totalSecondsBreak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minutes = int.Parse(this.numericUpDown1.Value.ToString());
            totalSecondsWork = minutes * 60;
            int breakmin = int.Parse(this.numericUpDown2.Value.ToString());
            totalSecondsBreak = breakmin * 60;

            this.timer1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.label1.Text = "00:00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(totalSecondsWork > 0)
            {
                totalSecondsWork--;
                int minutes = totalSecondsWork / 60;
                int seconds = totalSecondsWork - (minutes * 60);
                this.label1.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else if(totalSecondsBreak > 0)
            {
                totalSecondsBreak--;
                int breakmin = totalSecondsBreak / 60;
                int breaksec = totalSecondsBreak - (breakmin * 60);
                this.label1.Text = breakmin.ToString() + ":" + breaksec.ToString();
            }
            else
            {
                this.timer1.Stop();
            }
        }
    }
}