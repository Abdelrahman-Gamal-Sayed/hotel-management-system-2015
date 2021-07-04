using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home s = new home();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            customer s = new customer();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            home s = new home();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Close();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            items s = new items();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            buying s = new buying();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            selling s = new selling();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            employee s = new employee();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            comp s = new comp();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
         
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
