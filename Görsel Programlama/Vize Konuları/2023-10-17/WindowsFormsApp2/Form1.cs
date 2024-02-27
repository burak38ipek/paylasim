using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // Font font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
           // label1.Font = font;

            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);

            if (checkBox1.Checked) label1.Text = "CheckBox1 işarteli";
            else label1.Text = "CheckBox1 işarteli değil";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked) label1.TextAlign = ContentAlignment.TopLeft;
                else if(radioButton2.Checked) label1.TextAlign = ContentAlignment.TopCenter;
                          else label1.TextAlign = ContentAlignment.TopRight;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
