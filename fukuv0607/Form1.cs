using System.Security.Cryptography.X509Certificates;

namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = -4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Top <= 0)
            {
                vy = -vy;
            }
            else if (label1.Left <= 0)
            {
                vx = -vx;
            }
            else if (label1.Top >= 410)
            {
                vy = -vy;
            }
            else if (label1.Left >= 700)
            {
                vx = -vx;
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "’·ú±—N“l";
        }
    }
}