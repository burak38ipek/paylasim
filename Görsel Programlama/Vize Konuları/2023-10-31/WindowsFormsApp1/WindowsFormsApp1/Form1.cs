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

        private void belgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yeni Belge seçildi";
        }

        private void çizimToolStripMenuItem_Click(object sender, EventArgs e)
        {
             label1.Text = "Yeni Çizim seçildi";
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Aç komutu seçildi";
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Kaydet komutu seçildi";
        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solaHizalaToolStripMenuItem.Checked = true;
            sağaHizalaToolStripMenuItem.Checked = false;
            ortalaToolStripMenuItem.Checked = false;
        }

        private void ortalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solaHizalaToolStripMenuItem.Checked = false;
            sağaHizalaToolStripMenuItem.Checked = false;
            ortalaToolStripMenuItem.Checked = true;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solaHizalaToolStripMenuItem.Checked = false;
            sağaHizalaToolStripMenuItem.Checked = true;
            ortalaToolStripMenuItem.Checked = false;
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
