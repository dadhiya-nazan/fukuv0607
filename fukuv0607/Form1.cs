using System.Security.Cryptography.X509Certificates;

namespace fukuv0607
{
    public partial class Form1 : Form
    {

        double vx = random.Next(-11,11);
        double vy = random.Next(-11,11);
        int toki = 2;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var fpos = PointToClient(MousePosition);
            //label1.Text = $"{fops X},{fpos Y}";
            label2.Left = fpos.X;
            label2.Top = fpos.Y;

            label1.Left += (int)vx;
            label1.Top += (int)vy;
            if (label1.Top <= 0)
            {
                vy = Math.Abs(random.Next(5,11));
                label1.Text = "ì™í…Ç¢";
            }
            else if (label1.Left <= 0)
            {
                vx = Math.Abs(random.Next(5,11));
                label1.Text = "ç∂îºêgí…Ç¢";
            }
            else if (label1.Top + label1.Height >= ClientSize.Height)
            {
                vy = -Math.Abs(random.Next(5,11));
                label1.Text = "ë´í…Ç¢";
            }
            else if (label1.Left + label1.Width >= ClientSize.Width)
            {
                vx = -Math.Abs(random.Next(5,11));
                label1.Text = "âEîºêgí…Ç¢";
            }
            else
            {

            }

            if ((label1.Left < fpos.X) && (label1.Right > fpos.X) && (label1.Top < fpos.Y) && (label1.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label4.Text = $"{toki}ïbÇ≈é~ÇﬂÇΩ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "í∑˙±óNìl";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            label4.Text = $"{toki}";
            toki++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label6.Text = $"{Math.Abs(vx)}";
            label8.Text = $"{Math.Abs(vy)}";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}