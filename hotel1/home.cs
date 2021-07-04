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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void amin_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button c = new Button();
            c.Image = amin.Image;
            amin.Image = maro.Image;
            maro.Image = c.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buying newform = new buying();
            newform.Show();
            this.Hide();
        }
    }
}
