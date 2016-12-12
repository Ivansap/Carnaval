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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder();
            n.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SuitBack s = new SuitBack();
            s.Show();
        }
    }
}
