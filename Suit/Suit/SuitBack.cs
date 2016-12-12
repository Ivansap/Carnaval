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
    public partial class SuitBack : Form
    {
        public SuitBack()
        {
            InitializeComponent();
            
        }

        private void SuitBack_Load(object sender, EventArgs e)
        {

        }
        // ок
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cancel
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // suit
        private void button14_Click(object sender, EventArgs e)
        {
            Suits s = new Suits(this);
            this.Enabled = false;
            s.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled) dataGridView1.Enabled = false;
            else dataGridView1.Enabled = true;
        }
    }
}
