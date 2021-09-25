using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaSipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string adisoyadi;
        


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Ekstralar.Items.Add("Mantar ");
            }
            else
            {
                Ekstralar.Items.Remove("Mantar ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
                label4.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                label4.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Ekstralar.Items.Add("Sucuk");
            }
            else
            {
                Ekstralar.Items.Remove("Sucuk");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Ekstralar.Items.Add("Kaşar ");
            }
            else
            {
                Ekstralar.Items.Remove("Kaşar ");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Ekstralar.Items.Add("Zeytin ");
            }
            else
            {
                Ekstralar.Items.Remove("Zeytin ");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                Ekstralar.Items.Add("Mısır ");
            }
            else
            {
                Ekstralar.Items.Remove("Mısır ");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                Ekstralar.Items.Add("Biber ");
            }
            else
            {
                Ekstralar.Items.Remove("Biber ");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            adisoyadi = "SAYIN, "+textBox1.Text;
            label13.Text = adisoyadi;
            label14.Text ="PİZZA BOYUTU : "+ comboBox2.SelectedItem.ToString() + " PİZZA";
            for (int i = 0; Ekstralar.Items.Count > i; i++)
            {
                label15.Text += Ekstralar.Items[i].ToString();
            }
            label6.Text= "İÇECEK : " + comboBox1.SelectedItem.ToString();
            label7.Text = "SİPARİŞ ADRESİNİZ : " + textBox2.Text;
            label8.Text = "İRTİBAT NUMARASI : " + maskedTextBox1.Text;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
