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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        Order order;
        public NewOrder(Order r)
        {
            InitializeComponent();
            order = r;
        }
        bool is_back = false;
        public NewOrder(Order r, string d)
        {
            InitializeComponent();
            order = r;
            is_back = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void NewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            order.Enabled = true;
        }
        // ok name
        private void button2_Click(object sender, EventArgs e)
        {
            if (is_back)
            {
                SuitBack s = new SuitBack();
                s.Show();
            }

            this.Close();
        }
        // cancel name
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ok art
        private void button8_Click(object sender, EventArgs e)
        {
            if (is_back)
            {
                SuitBack s = new SuitBack();
                s.Show();
            }

            this.Close();
        }
        // cancel art
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ... name
        private void button14_Click(object sender, EventArgs e)
        {

        }
        // ... art
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
