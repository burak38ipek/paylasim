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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            Form3 frm3 = new Form3();
            
            cevap = frm3.ShowDialog();
            if (cevap == DialogResult.OK)  label1.Text = "Pencere Tamam ile kapatıldı";
            else if (cevap == DialogResult.Cancel) label1.Text = "Pencere İptal ile kapatıldı";
                 else label1.Text = "Pencere Yoksay ile kapatıldı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yükleniyor");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Kapatılıyor");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Kapatıldı");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = Convert.ToString( e.Y );
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = e.X.ToString();
            label4.Text = e.Y.ToString();
        }

       private void Form1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Girildi";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "Çıkıldı";
        }

        int sayı = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Text = e.X.ToString();
            label8.Text = e.Y.ToString();
            label9.Text = sayı.ToString();
            sayı++;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label10.Text = this.Width.ToString();
            label11.Text = this.Height.ToString();
        }
    }
}
