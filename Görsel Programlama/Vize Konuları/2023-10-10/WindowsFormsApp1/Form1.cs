using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tıklandı");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Fare Tıklandı");
        }
        
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Fare basıldı");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Fate bırakıldı");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fare girdi");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fare ayrıldı");
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            listBox2.Items.Add("Tuş aşağı");

            if (e.KeyCode == Keys.F1) label4.Text = "F1 basıldı";
            label5.Text = e.KeyCode.ToString();
            label6.Text = e.KeyValue.ToString();
            label7.Text = e.KeyData.ToString();
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox2.Items.Add("Tuş yukarı");
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox2.Items.Add("Tuş basıldı");
            label3.Text = e.KeyChar.ToString();
        }
        int x = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
            listBox3.Items.Add( textBox1.Text );
            x++;
            label9.Text = x.ToString();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            label10.Text = this.Width.ToString();
            label11.Text = this.Height.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Gösteriliyor");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Kapatılıyor");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Kapatıldı");
        }
    }
}
