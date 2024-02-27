using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            DialogResult cevap;
            cevap = fontDialog1.ShowDialog();
            if ( cevap == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = colorDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = colorDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = fontDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = colorDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = colorDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        



        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fontlar = new InstalledFontCollection();

            foreach (FontFamily font in fontlar.Families)
                listBox1.Items.Add(font.Name);

            foreach (FontFamily font in fontlar.Families)
                listBox2.Items.Add(font.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(listBox1.Text, textBox1.Font.Size, textBox1.Font.Style);

            Font yazıtipi = new Font("Arial", 20, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, Convert.ToUInt32(comboBox1.Text), textBox1.Font.Style);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = 
                new Font(listBox2.Text, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = 
                new Font(richTextBox1.SelectionFont.Name, Convert.ToInt32(comboBox2.Text), richTextBox1.SelectionFont.Style);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Strikeout);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) textBox1.TextAlign = HorizontalAlignment.Left;
            if (radioButton2.Checked) textBox1.TextAlign = HorizontalAlignment.Center;
            if (radioButton3.Checked) textBox1.TextAlign = HorizontalAlignment.Right;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            if (radioButton5.Checked) richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            if (radioButton6.Checked) richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
