using System.Drawing.Text;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int İkinci;

        private void button1_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "1";

                }
                else
                {
                    label1.Text += "1";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "1";

                }
                else
                {
                    label4.Text += "1";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "2";

                }
                else
                {
                    label1.Text += "2";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "2";

                }
                else
                {
                    label4.Text += "2";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "3";

                }
                else
                {
                    label1.Text += "3";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "3";

                }
                else
                {
                    label4.Text += "3";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "4";

                }
                else
                {
                    label1.Text += "4";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "4";

                }
                else
                {
                    label4.Text += "4";

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "5";

                }
                else
                {
                    label1.Text += "5";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "5";

                }
                else
                {
                    label4.Text += "5";

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "6";

                }
                else
                {
                    label1.Text += "6";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "6";

                }
                else
                {
                    label4.Text += "6";

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "7";

                }
                else
                {
                    label1.Text += "7";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "7";

                }
                else
                {
                    label4.Text += "7";

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "8";

                }
                else
                {
                    label1.Text += "8";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "8";

                }
                else
                {
                    label4.Text += "8";

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "9";

                }
                else
                {
                    label1.Text += "9";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "9";

                }
                else
                {
                    label4.Text += "9";

                }
            }
        }


        private void button13_Click(object sender, EventArgs e) //0
        {
            if (İkinci == 0)
            {
                if (label1.Text == "0")
                {
                    label1.Text = "0";

                }
                else
                {
                    label1.Text += "0";

                }
            }
            else
            {
                if (label4.Text == "0")
                {
                    label4.Text = "0";

                }
                else
                {
                    label4.Text += "0";

                }
            }
        }

        private void button16_Click(object sender, EventArgs e) // bölme
        {
            label3.Text = "/";
            label3.Visible = true;
            İkinci = 1;
        }

        private void button14_Click(object sender, EventArgs e) // eşittir
        {
            if (label3.Text == "+")
            {
                label5.Text = Convert.ToString(Convert.ToInt32(label1.Text) + Convert.ToInt32(label4.Text));
                İkinci = 0;
                label1.Text = "0";
                label4.Text = "0";
                label3.Text = "";
                label3.Visible = false;

            }
            else if (label3.Text == "×")
            {
                label5.Text = Convert.ToString(Convert.ToInt32(label1.Text) * Convert.ToInt32(label4.Text));
                İkinci = 0;
                label1.Text = "0";
                label4.Text = "0";
                label3.Text = "";

                label3.Visible = false;
            }
            else if (label3.Text == "-")
            {
                label5.Text = Convert.ToString(Convert.ToInt32(label1.Text) - Convert.ToInt32(label4.Text));
                İkinci = 0;
                label1.Text = "0";
                label4.Text = "0";
                label3.Text = "";

                label3.Visible = false;
            }
            else if (label3.Text == "/")
            {
                label5.Text = Convert.ToString(Convert.ToDecimal(label1.Text) / Convert.ToDecimal(label4.Text));
                İkinci = 0;
                label1.Text = "0";
                label4.Text = "0";
                label3.Text = "";

                label3.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e) // çarpma
        {
            label3.Text = "×";
            label3.Visible = true;
            İkinci = 1;

        }

        private void button11_Click(object sender, EventArgs e) // toplama
        {
            label3.Text = "+";
            label3.Visible = true;
            İkinci = 1;

        }

        private void button10_Click(object sender, EventArgs e) //çıkarma
        {
            label3.Text = "-";
            label3.Visible = true;
            İkinci = 1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label3.Text = "";
            İkinci = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
