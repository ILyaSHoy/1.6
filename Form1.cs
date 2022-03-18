using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkRed;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gold;
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGreen;
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkBlue;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
    }
}
