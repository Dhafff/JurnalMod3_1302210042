using System.ComponentModel;

namespace JurnalMod3_1302210042
{
    public partial class Form1 : Form
    {

        int a, hasil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = int.Parse(this.label1.Text);
            this.label1.Text = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = a + int.Parse(this.label1.Text);
            this.label1.Text = hasil.ToString();
        }
    }
}
