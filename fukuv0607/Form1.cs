using System.Security.Cryptography.X509Certificates;

namespace fukuv0607
{
    public partial class Form1 : Form
    {
        double vx = -4;
        double vy = -4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += (int)vx;
            label1.Top += (int)vy;
            if (label1.Top < 0)
            {
                vy = -(1.5 * vy);
                label1.Text = "ì™í…Ç¢";
            }
            else if (label1.Left < 0)
            {
                vx = -(1.5 * vx);
                label1.Text = "ç∂îºêgí…Ç¢";
            }
            else if (label1.Top > 400)
            {
                vy = -(1.5 * vy);
                label1.Text = "ë´í…Ç¢";
            }
            else if (label1.Left > 700)
            {
                vx = -(1.5 * vx);
                label1.Text = "âEîºêgí…Ç¢";
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "í∑˙±óNìl";
        }
    }
}