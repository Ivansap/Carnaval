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
            Order o = new Order();
            o.Show();
        }

   
    }
}
