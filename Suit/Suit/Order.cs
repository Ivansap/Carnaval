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
        DataBase db;
        public Order(Form1 f)
        {
            db = new DataBase();
            InitializeComponent();
            form1 = f;
            comboBox6.DataSource = db.fillClientCombo();
            comboBox6.DisplayMember = "Клиент";
            comboBox6.ValueMember = "id";
        }
        string form = "start_form";
        Form1 form1;
        public Order(string f, Form1 f1)
        {
            InitializeComponent();
            form = f;
            form1 = f1;
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            db=new DataBase();
            changeForm(form);
            dataGridView1.DataSource = db.getAllOrders();
            //comboBox6.DataSource = db.fillClientCombo();
           // comboBox6.DisplayMember = "Клиент";
           // comboBox6.ValueMember = "id";
        }

       
        //+ add
        private void button6_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder(this);
            this.Enabled = false;
            n.Show();
        }
        private void changeForm(string formType)
        {
            switch (formType)
            {
                case "add":
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = false;
                        groupBox3.Visible = false;
                        textBox1.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                case "back":
                    {
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                        groupBox3.Visible = false;
                        textBox1.Enabled = false;
                        button4.Enabled = false;
                        button2.Enabled = false;
                        button1.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                case "change":
                    {
                        groupBox3.Visible = true;
                        groupBox2.Visible = false;
                        groupBox1.Visible = false;
                        textBox1.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                case "start_form":
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        groupBox3.Visible = false;
                        textBox1.Enabled = true;
                        button4.Enabled = true;
                        button2.Enabled = true;
                        button1.Enabled = true;
                        button3.Enabled = true;
                        break;
                    }
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            changeForm("add");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeForm("change");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeForm("back");
        }
        //ok add
        private void button8_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel add
        private void button9_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //ok back
        private void button11_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel back
        private void button10_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //ok change
        private void button19_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel change
        private void button18_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }

       
        //- add
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //+ back
        private void button14_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder(this, "back");
            this.Enabled = false;
            n.Show();
        }
        //-back
        private void button13_Click_1(object sender, EventArgs e)
        {

        }
        //+ change
        private void button21_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder(this);
            this.Enabled = false;
            n.Show();
        }
        //- change
        private void button20_Click(object sender, EventArgs e)
        {

        }
        //bill add
        private void button23_Click(object sender, EventArgs e)
        {

        }
        //bill back
        private void button24_Click(object sender, EventArgs e)
        {

        }
        //bill change
        private void button25_Click(object sender, EventArgs e)
        {

        }
        // ... client add
        private void button5_Click(object sender, EventArgs e)
        {
            Clients c = new Clients("start_form", this);
            this.Enabled = false;
            c.Show();
        }
        // ... client back
        private void button16_Click(object sender, EventArgs e)
        {
            Clients c = new Clients("start_form", this);
            this.Enabled = false;
            c.Show();
        }
        // ...  client change
        private void button22_Click(object sender, EventArgs e)
        {
            Clients c = new Clients("start_form", this);
            this.Enabled = false;
            c.Show();
        }

        public int GetClient(int id)
        { return id; }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { form1.Enabled = true; }
            catch { }
        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            string s = comboBox6.Text;
            if (s != "")
            {
                comboBox6.DataSource = db.getClientsToCombo(s); 
            }
            else comboBox6.DataSource = db.fillClientCombo(); 
                comboBox6.DisplayMember = "Клиент";
                comboBox6.ValueMember = "id";
           
        }

    
    }
}
