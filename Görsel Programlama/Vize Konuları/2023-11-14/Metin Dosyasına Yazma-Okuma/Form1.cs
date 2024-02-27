using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Metin_Dosyasına_Yazma_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(textBox2.Text, textBox1.Text);
                MessageBox.Show(textBox1.TextLength.ToString() + " Byte Yazıldı");
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = File.ReadAllText(textBox2.Text);
                MessageBox.Show(textBox1.TextLength.ToString() + " Byte Okundu");
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Create(@"D:\örnek.txt");
            //FileStream dosya = File.OpenWrite("d:\\örnek.txt");

            byte[] metin = new UTF8Encoding(true).GetBytes(textBox1.Text);
            dosya.Write(metin, 0, metin.Length);

            dosya.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FileStream dosya = File.Open("d:\\örnek.txt", FileMode.Open);
            //FileStream dosya = File.OpenRead("d:\\örnek.txt");

            byte[] veri = new byte[dosya.Length];
            dosya.Read(veri, 0, Convert.ToInt32(dosya.Length));

            textBox1.Text = Encoding.Default.GetString(veri);

            dosya.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
