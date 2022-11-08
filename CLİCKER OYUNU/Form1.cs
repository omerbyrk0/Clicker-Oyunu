using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLİCKER_OYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int altın = 0;
        int hit = 30;
        int i, a = 0;
        

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "500 ALTIN";
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "1.000 ALTIN";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "2.000 ALTIN";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "4.000 ALTIN";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "8.000 ALTIN";
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "15.000 ALTIN";
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "25.000 ALTIN";
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "50.000 ALTIN";
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "100.000 ALTIN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            carpma.Visible = false;
            carpma2.Visible=false;
            carpma3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carpma.Visible = false;
            carpma2.Visible = false;
            carpma3.Visible = false;
            altın += 20;
            label3.Text = altın.ToString();

            hpbas();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            altın += hit;
            label3.Text = altın.ToString();
            progressBar1.Value--;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (altın >= 500) 
            {
                hit = 50;
                altın = altın - 500;
                pictureBox2.BackColor = Color.Green;
                pictureBox2.Enabled = false;
                
            }
            else
            {
                pictureBox2.BackColor= Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (altın >= 1000)
            {
                hit = 70;
                altın = altın - 1000;
                pictureBox3.BackColor = Color.Green;
                pictureBox3.Enabled = false;
            }
            else
            {
                pictureBox3.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (altın >= 2000)
            {
                hit = 100;
                altın = altın - 2000;
                pictureBox4.BackColor = Color.Green;
                pictureBox4.Enabled = false;
            }
            else
            {
                pictureBox4.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (altın >= 4000)
            {
                hit = 120;
                altın = altın - 4000;
                pictureBox5.BackColor = Color.Green;
                pictureBox5.Enabled = false;
            }
            else
            {
                pictureBox5.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (altın >= 8000)
            {
                hit = 150;
                altın = altın - 8000;
                pictureBox6.BackColor = Color.Green;
                pictureBox6.Enabled = false;
            }
            else
            {
                pictureBox6.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (altın >= 15000)
            {
                hit = 200;
                altın = altın - 15000;
                pictureBox7.BackColor = Color.Green;
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox7.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (altın >= 25000)
            {
                hit = 250;
                altın = altın - 25000;
                pictureBox8.BackColor = Color.Green;
                pictureBox8.Enabled = false;
            }
            else
            {
                pictureBox8.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (altın >= 50000)
            {
                hit = 300;
                altın = altın - 50000;
                pictureBox9.BackColor = Color.Green;
                pictureBox9.Enabled = false;
            }
            else
            {
                pictureBox9.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (altın >= 100000)
            {
                hit = 500;
                altın = altın - 100000;
                pictureBox10.BackColor = Color.Green;
                pictureBox10.Enabled = false;
            }
            else
            {
                pictureBox10.BackColor = Color.Red;
                label1.Text = "ALTIN YETERSİZ";
            }
        }

        private void hpbas()
        {

            if (i == 0)
            {
                if (progressBar1.Value == 50)
                {
                    carpma.Visible = true;
                    carpma2.Visible = true;
                    progressBar1.Value = 70;
                    progressBar2.Value = 80;
                    carpma.BringToFront();//efekti öne alma metotu
                    carpma.BackColor = Color.Transparent;//arka planını saydam yap
                    pictureBox11.Image = Properties.Resources.Adsız_tasarım__1_;
                    i++;


                }
            }

            else if (a == 0)
            {
                if (progressBar1.Value == 30)
                {
                    carpma.Visible = true;
                    carpma3.Visible = true;
                    progressBar1.Value = 50;
                    progressBar2.Value = 50;
                    carpma.BringToFront();//efekti öne alma metotu
                    carpma.BackColor = Color.Transparent;//arka planını saydam yap
                    pictureBox12.Image = Properties.Resources.Adsız_tasarım__1_;
                    a++;
                }
            }
           
            if(progressBar1.Value == 0)
            {
                progressBar1.Value = 100;
                MessageBox.Show("TEBRİKLER KAZANDINIZ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
