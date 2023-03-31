using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoGiGi
{
    public partial class Form2 : Form
    {
        double salarios = 0d;
        double novosalario = 0d;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            salarios = double.Parse(textBoxsal.Text);

            novosalario = salarios * 1.05;

            labelsalario.Text = string.Format("Novo Salario = {0:c}", novosalario);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            salarios = double.Parse(textBoxsal.Text);

            novosalario = salarios * 1.10;

            labelsalario.Text = string.Format("Novo Salario = {0:c}", novosalario);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salarios = double.Parse(textBoxsal.Text);

            novosalario = salarios * 1.15;

            labelsalario.Text = string.Format("Novo Salario = {0:c}", novosalario);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            salarios = double.Parse(textBoxsal.Text);

            novosalario = salarios * 1.20;

            labelsalario.Text = string.Format("Novo Salario = {0:c}", novosalario);
        }
    }
}
