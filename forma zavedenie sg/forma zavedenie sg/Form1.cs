using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma_zavedenie_sg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new меню();
            forma.Show();
            forma.BringToFront();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (checkBox1.Checked && checkBox21.Checked)
            {
                label4.Text = "vie ste " + a + "  dushi, iskate masa za pushachi" + ", plashtane v ke6";
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    if (!checkBox21.Checked)
                    {
                        label4.Text = "vie ste " + a + " iskate maza za pushachi ,iskash da platish s karta";
                    }
                }
            }
            if (checkBox1.Checked && checkBox22.Checked)
            {
                label4.Text = "vie ste " + a + "  dushi, iskate masa za nepushachi" + ", plashtane s karta";
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    if (!checkBox21.Checked)
                    {
                        label4.Text = "vie ste " + a + " iskate maza za nepushachi ,iskash da platish s karta";
                    }
                }
            }


            //if (checkBox2.Checked)
            //{
            //    MessageBox.Show("vie ste " + textBox1.Text + " choveka, iskate masa za pushachi i shte plashtash v kesh");
            //    if (checkBox1.Checked)
            //    {
            //        MessageBox.Show("vie ste " + textBox1.Text + " choveka, iskate masa za pushachi i shte plashtash v kesh");
            //    }
            //}
            //if (checkBox1.Checked)
            //{
            //    MessageBox.Show("vie ste " + textBox1.Text + " choveka i iskate masa za pushachi");
            //}
            //if (checkBox2.Checked)
            //{
            //    MessageBox.Show("masa za " + textBox1.Text + " choveka i iskate masa za nepushachi");
            //}

            //MessageBox.Show("masa za " + textBox1.Text + "choveka " );

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
