using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciocrecer
{
    public partial class Form1 : Form
    {
        float aumentar = 1.5f;
        double clickes = 0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Scale( + aumentar);
            clickes++;
            label1.Text = String.Format("( {0:0} ) Clique(s)", clickes);
        }
    }
}
