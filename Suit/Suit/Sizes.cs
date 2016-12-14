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
    public partial class Sizes : Form
    {
        Form1 form;
        Suits suit;
        public Sizes(Form1 f)
        {
            InitializeComponent();
            form = f;

        }
        public Sizes(Suits s)
        {
            InitializeComponent();
            suit = s;
        }
        private void Sizes_Load(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        private void changeForm(string formType)
        {
            switch (formType)
            {
                case "add":
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "change":
                    {
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "start_form":
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        button3.Enabled = true;
                        button2.Enabled = true;
                        button4.Enabled = true;
                        break;
                    }
            }
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            changeForm("add");
        }
        //change
        private void button3_Click(object sender, EventArgs e)
        {
            changeForm("change");
        }
        //delete
        private void button4_Click(object sender, EventArgs e)
        {

        }
        //ok change
        private void button7_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel change
        private void button1_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //ok add
        private void button5_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel add
        private void button6_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }

        private void Sizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form != null) form.Enabled = true;
            if (suit != null) suit.Enabled = true;
        }
    }
}
