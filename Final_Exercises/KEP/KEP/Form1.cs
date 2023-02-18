using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEP
{
    public partial class Form1 : Form
    {
        Boolean flag = true, flag2 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(flag).ShowDialog();
        }

        private void viewByCitizenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(!flag).ShowDialog();
        }

        private void searchBySocSecNumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4(flag2).ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4(!flag2).ShowDialog();
        }

    }
}
