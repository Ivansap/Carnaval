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
        string kind;

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

        public Suits(NewOrder f, string k)
        {
            InitializeComponent();
            order = f;
            kind = k;
        }

        private void Suits_Load(object sender, EventArgs e)
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
                        textBox1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "change":
                    {
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                        textBox1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "start_form":
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        textBox1.Enabled = true;
                        button3.Enabled = true;
                        button2.Enabled = true;
                        button4.Enabled = true;
                        break;
                    }
            }
        }
        private void Suits_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form1 != null) form1.Enabled = true;
            if (back != null) back.Enabled = true;
            if (order != null) order.Enabled = true;
        }
        //... change
        private void button9_Click(object sender, EventArgs e)
        {
            kind_suit k = new kind_suit(this);
            this.Enabled = false;
            k.Show();
        }
        // +  change
        private void button10_Click(object sender, EventArgs e)
        {
            Sizes s = new Sizes(this);
            this.Enabled = false;
            s.Show();
        }
        // - change
        private void button11_Click(object sender, EventArgs e)
        {

        }
        // cancel change
        private void button6_Click(object sender, EventArgs e)
        {

            changeForm("start_form");
        }
        //ok change
        private void button5_Click(object sender, EventArgs e)
        {

            changeForm("start_form");
        }
        // ... add
        private void button16_Click(object sender, EventArgs e)
        {
            kind_suit k = new kind_suit(this);
            this.Enabled = false;
            k.Show();
        }
        //+ add
        private void button15_Click(object sender, EventArgs e)
        {
            Sizes s = new Sizes(this);
            this.Enabled = false;
            s.Show();
        }
        //- add
        private void button14_Click(object sender, EventArgs e)
        {

        }
        //ok add
        private void button18_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel add
        private void button17_Click(object sender, EventArgs e)
        {
            changeForm("start_form");

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
        // delete
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
