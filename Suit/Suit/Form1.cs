using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Clients c = new Clients(this);
            c.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Employees c = new Employees(this);
            c.Show();
        }

        private void журналУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order(this);
            this.Enabled = false;
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order o = new Order("add", this);
            this.Enabled = false;
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = new Order("back", this);
            this.Enabled = false;
            o.Show();
        }

        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suits s = new Suits(this);
            this.Enabled = false;
            s.Show();
        }

        private void типыКостюмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kind_suit k = new kind_suit(this);
            this.Enabled = false;
            k.Show();
        }

        private void размерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sizes s = new Sizes(this);
            this.Enabled = false;
            s.Show();
        }

   
    }
}
