using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked == true)
            //{
            //    double num = double.Parse(textBox1.Text);
            //    num = num / 100;
            //    textBox2.Text = num.ToString();
            //}

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton3.Checked == true)
            //{
            //    double num = double.Parse(textBox1.Text);
            //    num = num / 100 / 1.6;
            //    textBox2.Text = num.ToString();
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked == true)
            //{
            //    double num = double.Parse(textBox1.Text);
            //    num = num * 100*1.6;
            //    textBox2.Text = num.ToString();
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                double num = double.Parse(textBox1.Text);
                num = num / 100;
                textBox2.Text = num.ToString();
            }
            else if(radioButton2.Checked == true) { 
                double num = double.Parse(textBox1.Text);
                num = num * 100 * 1.6;
                textBox2.Text = num.ToString();
            }
            else if(radioButton3.Checked == true)
            {
                double num = double.Parse(textBox1.Text);
                num = num / 100 / 1.6;
                textBox2.Text = num.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}