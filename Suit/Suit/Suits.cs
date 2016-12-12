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
    public partial class Suits : Form
    {
        Form1 form1;
        SuitBack back;
        NewOrder order;

        public Suits(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        public Suits(SuitBack f)
        {
            InitializeComponent();
            back = f;
        }

        public Suits(NewOrder f)
        {
            InitializeComponent();
            order = f;
        }

        private void Suits_Load(object sender, EventArgs e)
        {

        }

        private void Suits_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form1 != null) form1.Enabled = true;
            if (back != null) back.Enabled = true;
            if (order != null) order.Enabled = true;
        }
    }
}
